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
    public partial class GUsuarioExcluido : UserControl
    {
        private Usuario usuariologado;
        private Tecnico tecnico = new Tecnico();
        private GUserControlUsuarios gUser;

        public GUsuarioExcluido(GUserControlUsuarios gUserControl, Usuario usuario)
        {
            InitializeComponent();
            this.gUser = gUserControl;
            this.usuariologado = usuario;
        }

        private void GUsuarioExcluido_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            bool usuarioDelete = usuariologado.DeactivateUser(id, usuariologado);

            if (usuarioDelete)
            {
                gUser.CarregarUsuarios();
            }
            else
            {
                MessageBox.Show("Não é possível excluir o usuário. Ele pode estar associado a chamados ou ser o único administrador restante.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReativar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            bool usuarioreativar = usuariologado.ReactivateUser(id, usuariologado);

            if (usuarioreativar)
            {
                gUser.CarregarUsuarios();
            }
            else
            {
                MessageBox.Show("Não foi possível reativar o usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
