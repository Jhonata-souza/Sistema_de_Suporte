using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Data.SqlClient;

namespace Sistema_de_Suporte
{
    public class Tecnico
    {
        private Banco banco = new Banco();

        public int IdTecnico { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Especialidade { get; set; }

        // Relação
        public List<Atendimento> Atendimentos { get; set; } = new List<Atendimento>();

        // Função para registrar um novo técnico no banco de dados
        public bool CriarTecnico(string nome, string email, string especialidade)
        {
            try
            {
                this.Nome = nome;
                this.Email = email;
                this.Especialidade = especialidade;

                string query = "INSERT INTO TBTecnicos (nome, email, especialidade, ativo) VALUES (@nome, @email, @especialidade, 1)";
                using (SqlConnection con = banco.AbrirConexao())
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@especialidade", Especialidade);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar o técnico:\n{ex.Message}",
                                       "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Função para atualizar um campo específico do técnico
        public bool UpdateTecnicoField(int idTecnico, string campo, object valor, Usuario usuarioLogado)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    // Verifica se o técnico existe
                    var cmdVerifica = new SqlCommand(
                        "SELECT nome, email, especialidade FROM TBTecnicos WHERE id_tecnico = @ID",
                        connection
                    );
                    cmdVerifica.Parameters.AddWithValue("@ID", idTecnico);

                    using (var reader = cmdVerifica.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Técnico não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    // Define os campos permitidos para alteração
                    string[] camposPermitidos = { "NOME", "EMAIL", "ESPECIALIDADE" };
                    if (!camposPermitidos.Contains(campo.ToUpper()))
                    {
                        MessageBox.Show("Campo inválido para atualização.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    // Se for o email, verifica duplicidade (não pode existir outro técnico com o mesmo e-mail)
                    if (campo.ToUpper() == "EMAIL")
                    {
                        var checkCmd = new SqlCommand(
                            "SELECT COUNT(1) FROM TBTecnicos WHERE EMAIL = @EMAIL AND ID_TECNICO <> @ID",
                            connection
                        );
                        checkCmd.Parameters.AddWithValue("@EMAIL", valor);
                        checkCmd.Parameters.AddWithValue("@ID", idTecnico);

                        int existe = (int)checkCmd.ExecuteScalar();
                        if (existe > 0)
                        {
                            MessageBox.Show("Este e-mail já está em uso por outro técnico.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }

                    // Atualiza o campo solicitado
                    string query = $"UPDATE TBTecnicos SET {campo} = @VALOR WHERE ID_TECNICO = @ID";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@VALOR", valor);
                    cmd.Parameters.AddWithValue("@ID", idTecnico);

                    int linhas = cmd.ExecuteNonQuery();
                    if (linhas > 0)
                    {
                        Usuario usuario = new Usuario();
                        usuario.LogRegister(usuarioLogado.Id,
                            "Alteração de Técnico",
                            $"Campo '{campo}' do técnico ID {idTecnico} alterado para '{valor}'.");

                        MessageBox.Show($"Informação '{campo}' alterada com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma informação foi alterada.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o técnico:\n{ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Função para desativar um técnico do banco de dados
        public bool DeactivateTecnico(int idTecnico)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    // Verifica se o técnico existe
                    var cmdVerifica = new SqlCommand(
                        "SELECT ativo FROM TBTecnicos WHERE id_tecnico = @ID",
                        connection
                    );
                    cmdVerifica.Parameters.AddWithValue("@ID", idTecnico);

                    object result = cmdVerifica.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Técnico não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    bool ativo = Convert.ToBoolean(result);

                    if (!ativo)
                    {
                        MessageBox.Show("O técnico já está desativado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    // Atualiza o status do técnico para inativo
                    var cmd = new SqlCommand("UPDATE TBTecnicos SET ATIVO = 0 WHERE ID_TECNICO = @ID", connection);
                    cmd.Parameters.AddWithValue("@ID", idTecnico);

                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas > 0)
                    {
                        MessageBox.Show("Técnico desativado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum técnico encontrado com o ID informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao desativar técnico:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Função para reativar um técnico no banco de dados
        public bool ReactivateTecnico(int idTecnico)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    // Verifica se o técnico existe e se já está ativo
                    var cmdVerifica = new SqlCommand(
                        "SELECT ativo FROM TBTecnicos WHERE id_tecnico = @ID",
                        connection
                    );
                    cmdVerifica.Parameters.AddWithValue("@ID", idTecnico);

                    object result = cmdVerifica.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Técnico não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    bool ativo = Convert.ToBoolean(result);

                    if (ativo)
                    {
                        MessageBox.Show("O técnico já está ativo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    // Atualiza o status do técnico para ativo
                    var cmd = new SqlCommand("UPDATE TBTecnicos SET ATIVO = 1 WHERE ID_TECNICO = @ID", connection);
                    cmd.Parameters.AddWithValue("@ID", idTecnico);

                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas > 0)
                    {
                        MessageBox.Show("Técnico reativado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum técnico encontrado com o ID informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao reativar técnico:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
