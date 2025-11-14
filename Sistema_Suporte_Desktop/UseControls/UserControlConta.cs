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
    public partial class UserControlConta : UserControl
    {
        private Usuario usuarioLogado;
        private TelaPrincipal telaPrincipal;
        public UserControlConta(Usuario usuarioLogado, TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            this.telaPrincipal = telaPrincipal;
            this.usuarioLogado = usuarioLogado;

            // Atributos do usuario logado
            textBoxName.Text = usuarioLogado.Name;
            textBoxEmail.Text = usuarioLogado.Email;
            textBoxSenha.Text = "************";

            #region Elementos Invisíveis
            labelNome.Visible = false;
            labelEmail.Visible = false;
            labelAtual.Visible = false;
            labelNova.Visible = false;
            textBoxNome.Visible = false;
            textBox1.Visible = false;
            textBoxSenhaAtual.Visible = false;
            textBoxNovaSenha.Visible = false;
            buttonNome.Visible = false;
            buttonEmail.Visible = false;
            buttonSenha.Visible = false;
            buttonConta.Visible = false;
            #endregion
        }

        private void buttonConfiguracao_Click(object sender, EventArgs e)
        {
            #region Elementos Visíveis
            labelNome.Visible = true;
            labelEmail.Visible = true;
            labelAtual.Visible = true;
            labelNova.Visible = true;
            textBoxNome.Visible = true;
            textBox1.Visible = true;
            textBoxSenhaAtual.Visible = true;
            textBoxNovaSenha.Visible = true;
            buttonNome.Visible = true;
            buttonEmail.Visible = true;
            buttonSenha.Visible = true;
            buttonConta.Visible = true;
            #endregion
        }

        private void UserControlConta_Load(object sender, EventArgs e)
        {

        }

        private void buttonNome_Click(object sender, EventArgs e)
        {
            string novoNome = textBoxNome.Text;
            bool update = usuarioLogado.UpdateUserField(usuarioLogado.Id, "NOME", novoNome);
            if (update)
            {
                textBoxName.Text = novoNome;
            }
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            string novoEmail = textBox1.Text;
            bool update = usuarioLogado.UpdateUserField(usuarioLogado.Id, "EMAIL", novoEmail);
            if (update)
            {
                textBoxEmail.Text = novoEmail;
            }

        }

        private void buttonSenha_Click(object sender, EventArgs e)
        {
            string senhaAtual = textBoxSenhaAtual.Text;
            string novaSenha = textBoxNovaSenha.Text;
            usuarioLogado.ChangePassword(usuarioLogado.Id, senhaAtual, novaSenha);
        }

        private void buttonConta_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{usuarioLogado.Name}");
            bool delete = usuarioLogado.DeactivateUser(usuarioLogado.Id, usuarioLogado);
            if (delete)
            {
                Application.Restart();
            }
        }
    }
}
