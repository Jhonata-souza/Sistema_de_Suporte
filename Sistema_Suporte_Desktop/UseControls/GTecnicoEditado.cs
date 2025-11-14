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
    public partial class GTecnicoEditado : UserControl
    {
        private GUserControlTecnicos gTecnicos;
        private Tecnico tecnico;
        private Usuario usuarioLogado;

        public GTecnicoEditado(GUserControlTecnicos gUserControl, Usuario usuario)
        {
            InitializeComponent();
            tecnico = new Tecnico();
            this.gTecnicos = gUserControl;
            this.usuarioLogado = usuario;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int idTecnico = Convert.ToInt32(textBoxID.Text);
            string campo = comboBoxCampo.SelectedItem.ToString();
            string valor = textBox1.Text;

            tecnico.UpdateTecnicoField(idTecnico, campo, valor, usuarioLogado);
            gTecnicos.CarregarTecnicos();
        }

        private void GTecnicoEditado_Load(object sender, EventArgs e)
        {

        }
    }
}
