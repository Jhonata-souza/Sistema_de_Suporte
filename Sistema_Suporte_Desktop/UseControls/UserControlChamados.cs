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
    public partial class UserControlChamados : UserControl
    {
        private Usuario usuarioLogado;
        private TelaPrincipal telaPrincipal;
        public UserControlChamados(Usuario usuarioLogado, TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            this.usuarioLogado = usuarioLogado;
            this.telaPrincipal = telaPrincipal;
        }

        private void buttonChamados_Click(object sender, EventArgs e)
        {
            telaPrincipal.LoadForm(new UserChamados(usuarioLogado, telaPrincipal));
        }

        private void buttonNovosChamados_Click(object sender, EventArgs e)
        {
            telaPrincipal.LoadForm(new UserChamadosNovos(usuarioLogado));
        }

        private void UserControlChamados_Load(object sender, EventArgs e)
        {

        }
    }
}
