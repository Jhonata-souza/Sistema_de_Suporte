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
    public partial class GTecnicoExcluido : UserControl
    {
        private GUserControlTecnicos gUser;
        private Tecnico tecnico;
        private Usuario usuario;

        public GTecnicoExcluido(GUserControlTecnicos gUserControl)
        {
            InitializeComponent();
            tecnico = new Tecnico();
            this.gUser = gUserControl;
        }

        private void GTecnicoExcluido_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int idTecnico = int.Parse(textBoxID.Text);
            bool tecnicoDelete = tecnico.DeactivateTecnico(idTecnico);
            
            if(tecnicoDelete)
            {
                gUser.CarregarTecnicos();
            }
            else
            {
                MessageBox.Show("Não foi possível desativar o técnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReativar_Click(object sender, EventArgs e)
        {
            int idTecnico = int.Parse(textBoxID.Text);
            bool tecnicoReativar =  tecnico.ReactivateTecnico(idTecnico);

            if (tecnicoReativar)
            {
                gUser.CarregarTecnicos();
            }
            else
            {
                MessageBox.Show("Não foi possível reativar o técnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
