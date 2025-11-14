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
    public partial class GUserControlSugestoes : UserControl
    {
        private Banco banco;
        public GUserControlSugestoes()
        {
            InitializeComponent();
            banco = new Banco();
            CarregarSugestoes();
        }

        private void GUserControlSugestoes_Load(object sender, EventArgs e)
        {
            CarregarSugestoes();
        }

        private void CarregarSugestoes()
        {
            string query = "SELECT ID_SUGESTAO AS ID, ID_CHAMADO, CATEGORIA_SUGERIDA AS CATEGORIA, SOLUCAO_SUGERIDA AS SOLUCAO, ACURACIA FROM TBSUGESTOESIA";

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
