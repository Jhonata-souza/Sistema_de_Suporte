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
    public partial class TelaPrincipal : Form
    {
        private Usuario usuarioLogado;
        private UserControl activeControl = null;
        public TelaPrincipal(Usuario usuario)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";

            usuarioLogado = usuario;
            LoadForm(new UserControlTelaPrincipal(usuarioLogado, this));
        }

        // Função para trocar o UserControl que está no componente Panel
        public void LoadForm(UserControl newControl)
        {
            if (activeControl != null)
            {
                panelConteudo.Controls.Remove(activeControl);
                activeControl.Dispose();
            }

            activeControl = newControl;
            newControl.Dock = DockStyle.Fill;
            panelConteudo.Controls.Add(newControl);

            this.FormClosing += TelaPrincipal_FormClosing;
        }

        public void AbrirTelaChamados(Usuario usuario)
        {
            if (usuario.TypeUser == "Tecnico")
            {
                LoadForm(new UserControlTecnico(usuario));
            }
            else if (usuario.TypeUser == "Cliente")
            {
                LoadForm(new UserControlChamados(usuario, this));
            }
        }

        private void buttonPrincipal_Click(object sender, EventArgs e)
        {
            LoadForm(new UserControlTelaPrincipal(usuarioLogado, this));
        }

        private void buttonChamados_Click(object sender, EventArgs e)
        {
            AbrirTelaChamados(usuarioLogado);
        }

        private void buttonConta_Click(object sender, EventArgs e)
        {
            LoadForm(new UserControlConta(usuarioLogado, this));
        }

        private void panelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
