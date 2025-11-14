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
    public partial class TelaDeGerenciamento : Form
    {
        private Usuario usuarioLogado;
        private UserControl activeControl = null;

        public TelaDeGerenciamento(Usuario usuario)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Administrador";

            usuarioLogado = usuario;
            LoadForm(new UserControl());
            this.FormClosing += TelaDeGerenciamento_FormClosing;
        }

        // Função para trocar o UserControl que está no componente Panel
        public void LoadForm(UserControl newControl)
        {
            if (activeControl != null)
            {
                gpanelConteudo.Controls.Remove(activeControl);
                activeControl.Dispose();
            }

            activeControl = newControl;
            newControl.Dock = DockStyle.Fill;
            gpanelConteudo.Controls.Add(newControl);

        }

        private void TelaDeGerenciamento_Load(object sender, EventArgs e)
        {

        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            LoadForm(new GUserControlUsuarios(usuarioLogado));
        }

        private void buttonTecnico_Click(object sender, EventArgs e)
        {
            LoadForm(new GUserControlTecnicos(usuarioLogado));
        }

        private void buttonChamado_Click(object sender, EventArgs e)
        {
            LoadForm(new GUserControlChamados());
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            LoadForm(new GUserControlLogs());
        }

        private void buttonAtendimento_Click(object sender, EventArgs e)
        {
            LoadForm(new GUserControlAtendimentos());
        }

        private void buttonSugestoes_Click(object sender, EventArgs e)
        {
            LoadForm(new GUserControlSugestoes());
        }

        private void gpanelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaDeGerenciamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
