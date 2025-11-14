using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;

namespace Sistema_de_Suporte
{
    public class Atendimento
    {
        private Banco banco = new Banco();

        public int IdAtendimento { get; set; }
        public int IdChamado { get; set; }
        public int IdTecnico { get; set; }
        public string DescricaoSolucao { get; set; }

        // Método para registrar um atendimento
        public bool RegistrarAtendimento(int idChamado, int idTecnico, string descricaoSolucao)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO TBAtendimentos (id_chamado, id_tecnico, descricao_solucao)
                        VALUES (@id_chamado, @id_tecnico, @descricao_solucao);";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id_chamado", idChamado);
                        cmd.Parameters.AddWithValue("@id_tecnico", idTecnico);
                        cmd.Parameters.AddWithValue("@descricao_solucao", descricaoSolucao);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao registrar atendimento: {ex.Message}");
                return false;
            }
        }

        // Método para obter o ID do técnico pelo e-mail
        public int ObterIdTecnicoPorEmail(string email)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    string query = @"SELECT id_tecnico FROM TBTecnicos WHERE email = @Email;";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            // Nenhum técnico encontrado com esse e-mail
                            return -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter id do técnico: {ex.Message}");
                return -1;
            }
        }

    }
}
