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
    public partial class UserControlTelaPrincipal : UserControl
    {
        // Variavel da classe Usuario e TelaPrincipal
        private Usuario usuarioLogado;
        private TelaPrincipal telaPrincipal;

        public UserControlTelaPrincipal(Usuario usuarioLogado, TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            // usuario que esta logado é guardado nesta variavel
            this.usuarioLogado = usuarioLogado;
            this.telaPrincipal = telaPrincipal;
        }

        private void UserControlTelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void buttonChamados_Click(object sender, EventArgs e)
        {
            telaPrincipal.AbrirTelaChamados(usuarioLogado);
        }

        private void buttonConta_Click(object sender, EventArgs e)
        {
            telaPrincipal.LoadForm(new UserControlConta(usuarioLogado, telaPrincipal));
        }
    }
}
