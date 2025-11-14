using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sistema_de_Suporte
{
    public partial class TelaDeCadastro : Form
    {
        private Usuario usuario; // Atributo usuario
        public TelaDeCadastro()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += TelaDeCadastro_FormClosing;
            Text = "Cadastro";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            // Dados para o registro no banco de dados
            string nome = textBoxName.Text;
            string email = textBoxEmail.Text;
            string senha = textBoxPassword.Text;

            // Validação simples
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!checkBoxTermos.Checked)
                {
                    MessageBox.Show("Leia e aceite os Termos e Condições!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    usuario = new Usuario();
                    bool cadastroOk = usuario.RegisterUser(nome, email, senha, "Cliente", true, true);

                    if (cadastroOk)
                    {
                        Usuario usuarioLogado = usuario.LoginVerifier(email, senha);
                        AbrirTela(usuarioLogado);
                    }
                }
            }
        }

        // Link para a tela de login
        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaDeLogin telaDeLogin = new TelaDeLogin();
            telaDeLogin.Show();
            this.Hide();
        }

        public void AbrirTela(Usuario usuario)
        {
            if (usuario.TypeUser == "Admin")
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

        private void TelaDeCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
