using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BCrypt.Net; // Biblioteca para garantir a segurança das senhas
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

using Microsoft.Data.SqlClient;

namespace Sistema_de_Suporte
{
    public class Usuario
    {
        private Banco banco; // Atributo do banco

        // Atributos do usuario
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TypeUser { get; set; }
        public int Consent { get; set; }
        public int Active { get; set; }

        // Construtor do usuario
        public Usuario()
        {
            banco = new Banco();
        }

        // Função para computar o Hash de uma senha
        public void HashPassword(string password)
        {
            Password = BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Metodo para cadastrar usuarios
        public bool RegisterUser(string name, string email, string password, string typeUser, bool consent, bool ativo)
        {
            try
            {
                Name = name;
                Email = email;
                Password = BCrypt.Net.BCrypt.HashPassword(password); // Hash da senha
                TypeUser = typeUser;
                Consent = consent ? 1 : 0;
                Active = ativo ? 1 : 0;
                int novoId = 0;

                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();
                    var cmd = new SqlCommand("EXECUTE INSERIR_USUARIO @NOME, @EMAIL, @SENHA, @TIPO, @CONSENT, @ATIVO", connection);

                    cmd.Parameters.AddWithValue("@NOME", Name);
                    cmd.Parameters.AddWithValue("@EMAIL", Email);
                    cmd.Parameters.AddWithValue("@SENHA", Password);
                    cmd.Parameters.AddWithValue("@TIPO", TypeUser);
                    cmd.Parameters.AddWithValue("@CONSENT", Consent);
                    cmd.Parameters.AddWithValue("@ATIVO", Active);

                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        novoId = id;
                    }
                }
                // Registra o novo Log
                LogRegister(novoId, "Cadastro de Usuario", $"Usuario {email} foi cadastrado com sucesso no sistema.");

                // Cria o objeto de usuario
                Usuario novoUsuario = LoginVerifier(Email, Password);

                //if (novoUsuario != null)
                //{
                //    Usuario usuarioLogado = novoUsuario;
                //    MessageBox.Show("Usuário cadastrado e login efetuado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Metodo para verificar o login
        public Usuario LoginVerifier(string email, string senha)
        {
            try
            {
                using(var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();
                    var cmd = new SqlCommand("SELECT ID_USUARIO, NOME, EMAIL, SENHA, TIPO_USUARIO, CONSENTIMENTO_LGPD FROM TBUSUARIOS WHERE EMAIL = @EMAIL AND ATIVO = 1", connection);
                    cmd.Parameters.AddWithValue("@EMAIL", email);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            string hashSalvo = reader["SENHA"].ToString();
                            if (BCrypt.Net.BCrypt.Verify(senha, hashSalvo))
                            {
                                // Armazena o login
                                Usuario usuarioLogado = new Usuario 
                                {
                                    Id = Convert.ToInt32(reader["ID_USUARIO"]),
                                    Name = reader["NOME"].ToString(),
                                    Email = reader["EMAIL"].ToString(),
                                    TypeUser = reader["TIPO_USUARIO"].ToString(),
                                    Consent = Convert.ToInt32(reader["CONSENTIMENTO_LGPD"])
                                };

                                // Registra o log de Login
                                //LogRegister(usuarioLogado.Id, "Login", $"Usuário {usuarioLogado.Email} realizou login no sistema.");

                                return usuarioLogado; // Login correto
                            }
                        }
                    }
                }
                return null; // Login incorreto
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar login:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Função para alterar a senha do usuario
        public bool ChangePassword(int idUsuario, string senhaAtual, string novaSenha)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    // buscando a senha atual
                    var cmdVerifica = new SqlCommand("SELECT SENHA FROM TBUsuarios WHERE ID_USUARIO = @ID", connection);
                    cmdVerifica.Parameters.AddWithValue("@ID", idUsuario);

                    string hashAtual = cmdVerifica.ExecuteScalar()?.ToString();

                    if (string.IsNullOrEmpty(hashAtual))
                    {
                        MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Verifica se a senha atual esta correta
                    if (!BCrypt.Net.BCrypt.Verify(senhaAtual, hashAtual))
                    {
                        MessageBox.Show("Senha atual incorreta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    // Gera o novo hash
                    string novoHash = BCrypt.Net.BCrypt.HashPassword(novaSenha);

                    // Atualiza o banco
                    var cmdUpdate = new SqlCommand("UPDATE TBUsuarios SET SENHA = @NOVA_SENHA WHERE ID_USUARIO = @ID", connection);
                    cmdUpdate.Parameters.AddWithValue("@NOVA_SENHA", novoHash);
                    cmdUpdate.Parameters.AddWithValue("@ID", idUsuario);
                    
                    int linhas = cmdUpdate.ExecuteNonQuery();
                    if (linhas > 0)
                    {
                        LogRegister(idUsuario, "Alteração de Senha", "Usuário alterou sua senha com sucesso.");
                        MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma senha foi alterada. Verifique o ID do usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar senha:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Função para alterar a senha do usuario sem a senha atual (admin)
        public bool ChangePasswordById(int idUsuario, string novaSenha)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    // Verifica se o usuário existe e obtém o tipo
                    var cmdVerifica = new SqlCommand(
                        "SELECT tipo_usuario FROM TBUsuarios WHERE id_usuario = @ID",
                        connection
                    );
                    cmdVerifica.Parameters.AddWithValue("@ID", idUsuario);

                    object result = cmdVerifica.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    string tipoUsuario = result.ToString();

                    // Impede alteração da senha de administradores
                    if (tipoUsuario.Equals("admin", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Não é permitido alterar a senha de um usuário administrador.",
                            "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    // Gera o hash da nova senha
                    string novoHash = BCrypt.Net.BCrypt.HashPassword(novaSenha);

                    // Atualiza a senha no banco
                    var cmdUpdate = new SqlCommand("UPDATE TBUsuarios SET SENHA = @NOVA_SENHA WHERE ID_USUARIO = @ID", connection);
                    cmdUpdate.Parameters.AddWithValue("@NOVA_SENHA", novoHash);
                    cmdUpdate.Parameters.AddWithValue("@ID", idUsuario);

                    int linhas = cmdUpdate.ExecuteNonQuery();
                    if (linhas > 0)
                    {
                        LogRegister(idUsuario, "Alteração de Senha (Admin)", "Senha do usuário foi alterada sem confirmação da senha anterior.");
                        MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma senha foi alterada. Verifique o ID do usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar senha:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Função para alterar o registro do usuario
        public bool UpdateUserField(int idUsuario, string campo, object valor)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    // Verifica se o usuário existe e obtém o tipo
                    var cmdVerifica = new SqlCommand(
                        "SELECT tipo_usuario FROM TBUsuarios WHERE id_usuario = @ID",
                        connection
                    );
                    cmdVerifica.Parameters.AddWithValue("@ID", idUsuario);

                    object result = cmdVerifica.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    string tipoUsuario = result.ToString();

                    // Impede alteração da senha de administradores
                    if (tipoUsuario.Equals("admin", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Não é permitido alterar as informações da conta de um usuário administrador.",
                            "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    string[] camposPermitidos = { "NOME", "EMAIL" };
                    if (!camposPermitidos.Contains(campo.ToUpper()))
                    {
                        MessageBox.Show("Campo inválido para atualização.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    // Se for o email, verifica se ele ja existe
                    if (campo.ToUpper() == "EMAIL")
                    {
                        var checkCmd = new SqlCommand("SELECT COUNT(1) FROM TBUsuarios WHERE EMAIL = @EMAIL AND ID_USUARIO <> @ID", connection);
                        checkCmd.Parameters.AddWithValue("@EMAIL", valor);
                        checkCmd.Parameters.AddWithValue("ID", idUsuario);
                        int existe = (int)checkCmd.ExecuteScalar();
                        if(existe > 0)
                        {
                            MessageBox.Show("Este e-mail já está em uso por outro usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }

                    string query = $"UPDATE TBUsuarios SET {campo} = @VALOR WHERE ID_USUARIO = @ID";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@VALOR", valor);
                    cmd.Parameters.AddWithValue ("ID", idUsuario);

                    int linhas = cmd.ExecuteNonQuery();
                    if (linhas > 0)
                    {
                        LogRegister(idUsuario, "Alteração de Usuario", $"Campo '{campo}' alterado para '{valor}'.");
                        MessageBox.Show("Informação atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma informação foi alterada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o usuário:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Função para excluir uma conta
        public bool DeactivateUser(int idUsuario, Usuario usuarioLogado)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    // Verifica se o usuário existe e obtém o tipo
                    var cmdVerifica = new SqlCommand(
                        "SELECT tipo_usuario FROM TBUsuarios WHERE id_usuario = @ID",
                        connection
                    );
                    cmdVerifica.Parameters.AddWithValue("@ID", idUsuario);

                    object result = cmdVerifica.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    string tipoUsuario = result.ToString();

                    // Impede alteração da senha de administradores
                    if (tipoUsuario.Equals("admin", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Não é permitido desativar a conta de um usuário administrador.",
                            "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    // Atualiza o status do usuário para inativo
                    var cmd = new SqlCommand("UPDATE TBUSUARIOS SET ATIVO = 0 WHERE ID_USUARIO = @ID", connection);
                    cmd.Parameters.AddWithValue("@ID", idUsuario);

                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas > 0)
                    {
                        LogRegister(usuarioLogado.Id, "Desativação de Usuário", $"Usuário de ID {idUsuario} foi desativado por {usuarioLogado.Email}.");
                        MessageBox.Show("Usuário desativado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum usuário encontrado com o ID informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao desativar usuário:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Função para reativar uma conta
        public bool ReactivateUser(int idUsuario, Usuario usuarioLogado)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    // Verifica se o usuário existe e se já está ativo
                    var cmdVerifica = new SqlCommand(
                        "SELECT ativo FROM TBUsuarios WHERE id_usuario = @ID",
                        connection
                    );
                    cmdVerifica.Parameters.AddWithValue("@ID", idUsuario);

                    object result = cmdVerifica.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    bool ativo = Convert.ToBoolean(result);

                    if (ativo)
                    {
                        MessageBox.Show("O usuário já está ativo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    var cmd = new SqlCommand("UPDATE TBUSUARIOS SET ATIVO = 1 WHERE ID_USUARIO = @ID", connection);
                    cmd.Parameters.AddWithValue("@ID", idUsuario);

                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas > 0)
                    {
                        LogRegister(usuarioLogado.Id, "Reativação de Usuário", $"Usuário de ID {idUsuario} foi reativado por {usuarioLogado.Email}.");
                        MessageBox.Show("Usuário reativado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum usuário encontrado com o ID informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao reativar usuário:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Método para criar um usuario administrador
        public void CreateAdmin()
        {
            try
            {
                const string adminEmail = "admin@empresa.com";
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();
                    // Verifica a existencia do admin
                    using(var checkCmd = new SqlCommand("SELECT COUNT(1) FROM TBUSUARIOS WHERE EMAIL = @EMAIL", connection))
                    {
                        checkCmd.Parameters.AddWithValue("@EMAIL", adminEmail);
                        var countObj = checkCmd.ExecuteScalar();
                        int count = (countObj == null || countObj ==  DBNull.Value) ? 0 : Convert.ToInt32(countObj);
                        if(count > 0)
                        {
                            // A conta ja existia
                            //MessageBox.Show("Usuário administrador já existe.");
                        }
                        else
                        {
                            RegisterUser("Administrador", "admin@empresa.com", "123", "Admin", true, true);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao criar administrador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodo para registrar logs de auditoria
        public void LogRegister(int idUser, string action, string descricao)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    var cmd = new SqlCommand("EXECUTE ATUALIZAR_LOG @ID, @ACAO, @DATA_HORA, @DESCRICAO", connection);
                    cmd.Parameters.AddWithValue("@ID", idUser);
                    cmd.Parameters.AddWithValue("@ACAO", action);
                    cmd.Parameters.AddWithValue("DATA_HORA", DateTime.Now);
                    cmd.Parameters.AddWithValue("@DESCRICAO", descricao);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar log de auditoria:\n{ex.Message}", "Erro de log", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para alterar o tipo de usuario
        public bool ChangeUserType(int idUsuario, string novoTipo, Usuario usuarioLogado)
        {
            try
            {
                using (var connection = new SqlConnection(banco.stringConnection))
                {
                    connection.Open();

                    // Verifica se o usuário existe e obtém os dados
                    var cmdVerifica = new SqlCommand(
                        "SELECT nome, email, tipo_usuario FROM TBUsuarios WHERE id_usuario = @ID",
                        connection
                    );
                    cmdVerifica.Parameters.AddWithValue("@ID", idUsuario);

                    using (var reader = cmdVerifica.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        string tipoAtual = reader["tipo_usuario"].ToString();
                        string nome = reader["nome"].ToString();
                        string email = reader["email"].ToString();

                        // Impede alteração da conta de administradores
                        if (tipoAtual.Equals("admin", StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Não é permitido alterar a conta de um usuário administrador.",
                                "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                        reader.Close();

                        // Atualiza o tipo de usuário
                        var cmd = new SqlCommand("UPDATE TBUsuarios SET TIPO_USUARIO = @TIPO WHERE ID_USUARIO = @ID", connection);
                        cmd.Parameters.AddWithValue("@TIPO", novoTipo);
                        cmd.Parameters.AddWithValue("@ID", idUsuario);

                        int linhas = cmd.ExecuteNonQuery();

                        if (linhas > 0)
                        {
                            // Se o novo tipo for técnico, cria o técnico correspondente
                            if (novoTipo.Equals("tecnico", StringComparison.OrdinalIgnoreCase))
                            {
                                // Aqui você pode pedir ou definir a especialidade padrão
                                string especialidade = ""; // Exemplo: pode vir de um input, comboBox, etc.

                                // Instancia a classe Tecnico e chama o método
                                Tecnico tecnico = new Tecnico();
                                tecnico.CriarTecnico(nome, email, especialidade);
                            }

                            LogRegister(usuarioLogado.Id,
                                "Alteração de Tipo de Usuário",
                                $"Tipo do usuário ID {idUsuario} alterado para '{novoTipo}' por {usuarioLogado.Email}.");

                            MessageBox.Show($"Tipo de usuário alterado para '{novoTipo}' com sucesso!",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Nenhum usuário foi alterado. Verifique o ID do usuário.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar tipo de usuário:\n{ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}