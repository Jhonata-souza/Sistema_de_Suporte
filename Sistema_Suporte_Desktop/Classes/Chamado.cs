using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sistema_de_Suporte
{
    public class Chamado
    {
        private Banco banco = new Banco();

        public int IdChamado { get; set; }
        public int IdUsuario { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string Prioridade { get; set; }
        public string Status { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }

        // Converte JSON → Chamado e cadastra no banco
        public static Chamado FromJson(string json, int idUsuario)
        {
            Chamado chamado = new Chamado
            {
                IdUsuario = idUsuario,
                Status = "aberto",
                DataAbertura = DateTime.Now
            };

            try
            {
                var dados = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

                if (dados != null)
                {
                    chamado.Descricao = dados.ContainsKey("descricao") ? dados["descricao"] : "Sem descrição";
                    chamado.Categoria = dados.ContainsKey("categoria") ? dados["categoria"] : "Outros";
                    chamado.Prioridade = dados.ContainsKey("prioridade") ? dados["prioridade"].ToLower() : "baixa";
                }
                else
                {
                    chamado.Descricao = "Erro ao interpretar o JSON";
                    chamado.Categoria = "Desconhecida";
                    chamado.Prioridade = "baixa";
                }

                // Chama o método de inserção no banco
                if (chamado.RegistrarChamado())
                {
                    Console.WriteLine("Chamado registrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Falha ao registrar chamado no banco.");
                }
            }
            catch (Exception ex)
            {
                chamado.Descricao = $"Erro ao interpretar JSON: {ex.Message}";
                chamado.Categoria = "Desconhecida";
                chamado.Prioridade = "baixa";
            }

            return chamado;
        }

        // Função que insere na tabela TBChamados
        public bool RegistrarChamado()
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    // Pode ser uma stored procedure ou SQL direto
                    var cmd = new SqlCommand(@"
                        INSERT INTO TBChamados (id_usuario, descricao, categoria, prioridade, status, data_abertura)
                        OUTPUT INSERTED.id_chamado
                        VALUES (@id_usuario, @descricao, @categoria, @prioridade, @status, @data_abertura);", connection);

                    cmd.Parameters.AddWithValue("@id_usuario", IdUsuario);
                    cmd.Parameters.AddWithValue("@descricao", Descricao);
                    cmd.Parameters.AddWithValue("@categoria", Categoria);
                    cmd.Parameters.AddWithValue("@prioridade", Prioridade);
                    cmd.Parameters.AddWithValue("@status", Status);
                    cmd.Parameters.AddWithValue("@data_abertura", DataAbertura);

                    // Aqui obtém o ID gerado
                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        IdChamado = id;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Falha ao obter o ID do chamado após o insert.",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{IdUsuario}Erro ao registrar chamado:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public override string ToString()
        {
            return $"Descrição: {Descricao}\nCategoria: {Categoria}\nPrioridade: {Prioridade}\nStatus: {Status}\nData Abertura: {DataAbertura}";
        }

        // Atualiza o status do chamado
        public bool UpdateChamadoStatus(int idChamado, string novoStatus)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    // Verifica se o chamado já foi fechado
                    var checkCmd = new SqlCommand(@"SELECT data_fechamento FROM TBChamados WHERE id_chamado = @id_chamado;", connection);

                    checkCmd.Parameters.AddWithValue("@id_chamado", idChamado);

                    object result = checkCmd.ExecuteScalar();

                    // Se a data de fechamento não for nula, não permite atualização
                    if (result != DBNull.Value && result != null)
                    {
                        MessageBox.Show("O chamado já foi fechado e não pode ter o status alterado.",
                                        "Ação não permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    var cmd = new SqlCommand(@"
                        UPDATE TBChamados
                        SET status = @status
                        WHERE id_chamado = @id_chamado;", connection);

                    cmd.Parameters.AddWithValue("@status", novoStatus);
                    cmd.Parameters.AddWithValue("@id_chamado", idChamado);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar status do chamado:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Atualiza a prioridade do chamado
        public bool UpdateChamadoPrioridade(int idChamado, string novaPrioridade)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    // Verifica se o chamado já foi fechado
                    var checkCmd = new SqlCommand(@"SELECT data_fechamento FROM TBChamados WHERE id_chamado = @id_chamado;", connection);

                    checkCmd.Parameters.AddWithValue("@id_chamado", idChamado);

                    object result = checkCmd.ExecuteScalar();

                    // Se a data de fechamento não for nula, não permite atualização
                    if (result != DBNull.Value && result != null)
                    {
                        MessageBox.Show("O chamado já foi fechado e não pode ter a prioridade alterada.",
                                        "Ação não permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    var cmd = new SqlCommand(@"
                        UPDATE TBChamados
                        SET prioridade = @prioridade
                        WHERE id_chamado = @id_chamado;", connection);

                    cmd.Parameters.AddWithValue("@prioridade", novaPrioridade);
                    cmd.Parameters.AddWithValue("@id_chamado", idChamado);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar prioridade do chamado:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Adiciona a data de fechamento do chamado
        public bool FecharChamado(int idChamado)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    // Verifica se o chamado já foi fechado
                    var checkCmd = new SqlCommand(@"SELECT data_fechamento FROM TBChamados WHERE id_chamado = @id_chamado;", connection);

                    checkCmd.Parameters.AddWithValue("@id_chamado", idChamado);

                    object result = checkCmd.ExecuteScalar();

                    // Se a data de fechamento não for nula, não permite atualização
                    if (result != DBNull.Value && result != null)
                    {
                        MessageBox.Show("O chamado já foi fechado.",
                                        "Ação não permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    var cmd = new SqlCommand(@"
                        UPDATE TBChamados
                        SET status = @status, data_fechamento = @data_fechamento
                        WHERE id_chamado = @id_chamado;", connection);

                    cmd.Parameters.AddWithValue("@status", "fechado");
                    cmd.Parameters.AddWithValue("@data_fechamento", DateTime.Now);
                    cmd.Parameters.AddWithValue("@id_chamado", idChamado);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao fechar o chamado:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}