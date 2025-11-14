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
    public partial class GChamadoPrioridade : UserControl
    {
        private GUserControlChamados gUser;
        private Chamado chamado;
        public GChamadoPrioridade(GUserControlChamados gUserControl)
        {
            InitializeComponent();
            this.gUser = gUserControl;
            chamado = new Chamado();
        }

        private void GChamadoPrioridade_Load(object sender, EventArgs e)
        {

        }

        private void buttonAtt_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            string prioridade = comboBoxPrioridade.Text.ToLower();
            bool edit = chamado.UpdateChamadoPrioridade(id, prioridade);
            if (edit)
            {
                gUser.CarregarChamados();
                MessageBox.Show("Prioridade do Chamado Atualizada com Sucesso!", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
