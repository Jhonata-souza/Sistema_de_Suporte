using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Microsoft.Data.SqlClient; // Biblioteca para usar o banco de dados
using System.Windows.Forms;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Suporte
{
    internal class Banco
    {
        //String de conexão
        public string stringConnection =
            $@"Server=JHONATA\SQLSERVER;
            Database=DBSUPORTE; 
            TrustServerCertificate=True; 
            Integrated Security=True;";
        // Builder de conexão
        private SqlConnectionStringBuilder builder;

        // Construtor de Banco
        public Banco()
        {
            builder = new SqlConnectionStringBuilder(stringConnection);
            try
            {
                // Cria a conexão atravéz da string
                using(var connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    //MessageBox.Show("Conexão Bem Sucedida", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha:\n {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Função para executar os comandos SQL
        public void ExecuteSql(string command)
        {
            try
            {
                using (var connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    // Cria o objeto comando
                    var cmd = new SqlCommand(command, connection);
                    // Executa o comando
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Comando Bem Sucedido", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao tentar executar:\n {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Abre e retorna uma conexão com o banco
        public SqlConnection AbrirConexao()
        {
            try
            {
                var connection = new SqlConnection(stringConnection);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao abrir conexão com o banco: " + ex.Message);
            }
        }

    }
}
