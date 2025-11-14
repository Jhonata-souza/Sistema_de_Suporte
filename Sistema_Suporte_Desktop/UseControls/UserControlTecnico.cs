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
    public partial class UserControlTecnico : UserControl
    {
        private Banco banco = new Banco();
        private UserControl activeControl = null;
        private Usuario usuarioLogado;

        public UserControlTecnico(Usuario usuario)
        {
            InitializeComponent();
            CarregarChamados();
            this.usuarioLogado = usuario;
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

        public void LoadForm(UserControl newControl)
        {
            if (activeControl != null)
            {
                panel1.Controls.Remove(activeControl);
                activeControl.Dispose();
            }

            activeControl = newControl;
            newControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(newControl);

        }
        private void UserControlTecnico_Load(object sender, EventArgs e)
        {

        }

        private void buttonAtendimento_Click(object sender, EventArgs e)
        {
            LoadForm(new UserControlTecnicoAtendimento(usuarioLogado));
        }
    }
}
