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
    public partial class GUsuarioTecnico : UserControl
    {
        private Usuario usuarioLogado;
        private GUserControlUsuarios gUser;
        public GUsuarioTecnico(GUserControlUsuarios gUserControl, Usuario usuario)
        {
            InitializeComponent();
            this.usuarioLogado = usuario;
            this.gUser = gUserControl;
        }

        private void GUsuarioTecnico_Load(object sender, EventArgs e)
        {

        }

        private void buttonTecnico_Click(object sender, EventArgs e)
        {
            int idTecnico = Convert.ToInt32(textBoxID.Text);
            string campo = comboBoxCampo.SelectedItem.ToString();

            usuarioLogado.ChangeUserType(idTecnico, campo, usuarioLogado);
            gUser.CarregarUsuarios();
        }
    }
}
