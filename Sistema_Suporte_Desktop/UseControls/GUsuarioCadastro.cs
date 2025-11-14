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
    public partial class GUsuarioCadastro : UserControl
    {
        private Usuario usuario;
        private GUserControlUsuarios gUser;

        public GUsuarioCadastro(GUserControlUsuarios gUserControl)
        {
            InitializeComponent();
            this.gUser = gUserControl;
        }

        private void GUsuarioCadastro_Load(object sender, EventArgs e)
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
                usuario = new Usuario();
                bool cadastroOk = usuario.RegisterUser(nome, email, senha, "Cliente", true, true);

                if (cadastroOk)
                {
                    Usuario usuarioLogado = usuario.LoginVerifier(email, senha);
                    gUser.CarregarUsuarios();
                    MessageBox.Show("Usuario Registrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
