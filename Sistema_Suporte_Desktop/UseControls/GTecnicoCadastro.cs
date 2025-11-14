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
    public partial class GTecnicoCadastro : UserControl
    {
        private Usuario usuario;
        private Tecnico tecnico;
        private GUserControlTecnicos gUser;
        public GTecnicoCadastro(GUserControlTecnicos gUser)
        {
            InitializeComponent();
            usuario = new Usuario();
            tecnico = new Tecnico();
            this.gUser = gUser;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            // Dados para o registro no banco de dados
            string nome = textBoxName.Text;
            string email = textBoxEmail.Text;
            string senha = textBoxSenha.Text;
            string especialidade = textBoxEspecialidade.Text;

            // Validação simples
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                usuario = new Usuario();
                bool cadastroOk = usuario.RegisterUser(nome, email, senha, "Tecnico", true, true);
                bool cadastroTecnicoOk = tecnico.CriarTecnico(nome, email, especialidade);

                if (cadastroOk || cadastroTecnicoOk)
                {
                    Usuario usuarioLogado = usuario.LoginVerifier(email, senha);
                    gUser.CarregarTecnicos();
                    MessageBox.Show("Tecnico Registrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void GTecnicoCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
