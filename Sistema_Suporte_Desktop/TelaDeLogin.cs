using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Suporte
{
    public partial class TelaDeLogin : Form
    {
        // Atributo usuario
        private Usuario usuario;
        public TelaDeLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
        }

        private void TelaDeLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Variaveis para validação do login
            string email = textBoxEmail.Text;
            string senha = textBoxPassword.Text;

            // Validação
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Verificação do login
                usuario = new Usuario();
                Usuario usuarioLogado = usuario.LoginVerifier(email, senha);

                if(usuarioLogado != null || usuarioLogado.Active != 0)
                {
                    AbrirTela(usuarioLogado);
                    MessageBox.Show("Login efetuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Email ou Senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Link para a tela de cadastro
        private void linkLabelCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaDeCadastro telaDeCadastro = new TelaDeCadastro();
            telaDeCadastro.Show();
            this.Hide();
        }

        private void AbrirTela(Usuario usuario)
        {
            if(usuario.TypeUser == "Admin")
            {
                TelaDeGerenciamento telaGerente = new TelaDeGerenciamento(usuario);
                telaGerente.Show();
                this.Hide();
            }
            else
            {
                TelaPrincipal telaPrincipal = new TelaPrincipal(usuario);
                telaPrincipal.Show();
                this.Hide();
            }
        }

        private void TelaDeLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
