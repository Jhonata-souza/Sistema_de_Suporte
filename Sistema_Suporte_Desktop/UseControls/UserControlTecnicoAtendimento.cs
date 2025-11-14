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
    public partial class UserControlTecnicoAtendimento : UserControl
    {
        Usuario usuarioLogado;
        public UserControlTecnicoAtendimento(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioLogado = usuario;
        }

        private void UserControlTecnicoAtendimento_Load(object sender, EventArgs e)
        {

        }

        private void buttonConcluir_Click(object sender, EventArgs e)
        {
            int idChamado = Convert.ToInt32(textBoxIDChamado.Text);
            string solucao = textBoxSolucao.Text;
            string emailTecnico = usuarioLogado.Email;
            
            Atendimento atendimento = new Atendimento();
            int idTecnico = atendimento.ObterIdTecnicoPorEmail(emailTecnico);

            bool sucesso = atendimento.RegistrarAtendimento(idChamado, idTecnico, solucao);

            if (sucesso)
            {
                MessageBox.Show("Atendimento registrado com sucesso!");
                textBoxSolucao.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao registrar atendimento.");
            }
        }
    }
}
