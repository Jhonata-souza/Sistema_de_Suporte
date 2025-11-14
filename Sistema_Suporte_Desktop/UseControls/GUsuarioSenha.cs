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
    public partial class GUsuarioSenha : UserControl
    {
        private GUserControlUsuarios gUser;
        private Usuario usuario;

        public GUsuarioSenha(GUserControlUsuarios gUserControl)
        {
            InitializeComponent();
            this.gUser = gUserControl;
            usuario = new Usuario();
        }

        private void GUsuarioSenha_Load(object sender, EventArgs e)
        {

        }

        private void buttonSenha_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string novaSenha = textBoxNovaSenha.Text;

            usuario.ChangePasswordById(id, novaSenha);
        }
    }
}
