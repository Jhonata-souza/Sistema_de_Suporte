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
    public partial class GUsuarioEditado : UserControl
    {
        private Usuario usuario;
        private GUserControlUsuarios gUser;

        public GUsuarioEditado(GUserControlUsuarios gUserControl)
        {
            InitializeComponent();
            usuario = new Usuario();
            this.gUser = gUserControl;
        }

        private void GUsuarioEditado_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            string campo = comboBoxCampo.Text;
            string valor = textBoxValor.Text;

            bool edit = usuario.UpdateUserField(id, campo, valor);

            if (edit)
            {
                gUser.CarregarUsuarios();
                MessageBox.Show("Usuario Editado com Sucesso!", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
