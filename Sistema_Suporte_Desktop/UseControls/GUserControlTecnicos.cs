using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Data.SqlClient;

namespace Sistema_de_Suporte
{
    public partial class GUserControlTecnicos : UserControl
    {
        private Banco banco;
        private UserControl activeControl = null;
        private Usuario usuario;

        public GUserControlTecnicos(Usuario usuario)
        {
            InitializeComponent();
            banco = new Banco();
            CarregarTecnicos();
            this.usuario = usuario;
        }

        public void CarregarTecnicos()
        {
            string query = "SELECT ID_TECNICO AS ID, NOME, EMAIL, ESPECIALIDADE, ATIVO FROM TBTECNICOS";

            using (SqlConnection con = banco.AbrirConexao())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        public void LoadForm(UserControl newControl)
        {
            if (activeControl != null)
            {
                panelTecnicos.Controls.Remove(activeControl);
                activeControl.Dispose();
            }

            activeControl = newControl;
            newControl.Dock = DockStyle.Fill;
            panelTecnicos.Controls.Add(newControl);
        }

        private void GUserControlTecnicos_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            LoadForm(new GTecnicoCadastro(this));
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            LoadForm(new GTecnicoEditado(this, usuario));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            LoadForm(new GTecnicoExcluido(this));
        }
    }
}
