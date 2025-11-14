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
    public partial class GChamadoFechamento : UserControl
    {
        private GUserControlChamados gUser;
        private Chamado chamado;

        public GChamadoFechamento(GUserControlChamados gUserControl)
        {
            InitializeComponent();
            this.gUser = gUserControl;
            chamado = new Chamado();
        }

        private void buttonFechamento_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            bool edit = chamado.FecharChamado(id);
            if (edit)
            {
                gUser.CarregarChamados();
                MessageBox.Show("Chamado Fechado com Sucesso!", "Fechamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
