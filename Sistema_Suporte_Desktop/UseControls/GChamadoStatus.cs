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
    public partial class GChamadoStatus : UserControl
    {
        private Chamado chamado;
        private GUserControlChamados gUser;
        public GChamadoStatus(GUserControlChamados gUserControl)
        {
            InitializeComponent();
            chamado = new Chamado();
            this.gUser = gUserControl;
        }

        private void GChamadoStatus_Load(object sender, EventArgs e)
        {

        }

        private void buttonAtt_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            string status = comboBoxStatus.Text;
            bool att = chamado.UpdateChamadoStatus(id, status);
            if (att)
            {
                gUser.CarregarChamados();
                MessageBox.Show("Status do Chamado Atualizado com Sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
