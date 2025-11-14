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
    public partial class GUserControlChamados : UserControl
    {
        private Banco banco;
        private UserControl activeControl = null;

        public GUserControlChamados()
        {
            InitializeComponent();
            banco = new Banco();
            CarregarChamados();
        }

        public void CarregarChamados()
        {
            string query = "SELECT c.id_chamado AS ID, u.email AS EMAIL_USUARIO, c.descricao AS DESCRICAO, c.categoria AS CATEGORIA," +
                " c.prioridade AS PRIORIDADE, c.status AS STATUS, c.data_abertura AS DATA_ABERTURA, " +
                "c.data_fechamento AS DATA_FECHAMENTO FROM TBChamados AS c INNER JOIN TBUsuarios AS u ON c.id_usuario = u.id_usuario;";
            
            using (SqlConnection con = banco.AbrirConexao())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void LoadForm(UserControl newControl)
        {
            if (activeControl != null)
            {
                panelChamados.Controls.Remove(activeControl);
                activeControl.Dispose();
            }

            activeControl = newControl;
            newControl.Dock = DockStyle.Fill;
            panelChamados.Controls.Add(newControl);
        }

        private void GUserControlChamados_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            LoadForm(new GChamadoStatus(this));
        }

        private void buttonPrioridade_Click(object sender, EventArgs e)
        {
            LoadForm(new GChamadoPrioridade(this));
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            LoadForm(new GChamadoFechamento(this));
        }
    }
}
