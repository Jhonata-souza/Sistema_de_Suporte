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
    public partial class GUserControlLogs : UserControl
    {
        private Banco banco;
        public GUserControlLogs()
        {
            InitializeComponent();
            banco = new Banco();
            CarregarLogs();
        }

        private void CarregarLogs()
        {
            string query = "SELECT l.id_log AS ID, u.email AS EMAIL_USUARIO, l.acao AS AÇÃO, l.DATA_HORA, l.DESCRICAO " +
                "FROM TBLogsLGPD AS l INNER JOIN TBUsuarios AS u ON l.id_usuario = u.id_usuario;";

            using (SqlConnection con = banco.AbrirConexao())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }   

        private void GUserControlLogs_Load(object sender, EventArgs e)
        {

        }
    }
}
