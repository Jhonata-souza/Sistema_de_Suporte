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
    public partial class GUserControlAtendimentos : UserControl
    {
        private Banco banco;
        public GUserControlAtendimentos()
        {
            InitializeComponent();
            banco = new Banco();
            CarregarAtendimentos();
        }

        private void GUserControlAtendimentos_Load(object sender, EventArgs e)
        {
            CarregarAtendimentos();
        }

        private void CarregarAtendimentos()
        {
            string query = "SELECT a.id_atendimento AS ID, c.ID_CHAMADO, t.email AS EMAIL_TECNICO, a.DESCRICAO_SOLUCAO FROM TBAtendimentos " +
                "AS a INNER JOIN TBTecnicos AS t ON a.id_tecnico = t.id_tecnico INNER JOIN TBChamados AS c ON a.id_chamado = c.id_chamado;";

            using (SqlConnection con = banco.AbrirConexao())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
