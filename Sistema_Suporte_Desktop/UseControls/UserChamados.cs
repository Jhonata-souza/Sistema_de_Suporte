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
    public partial class UserChamados : UserControl
    {
        private Usuario usuarioLogado;
        private TelaPrincipal telaPrincipal;
        private Banco banco = new Banco();

        public UserChamados(Usuario usuarioLogado, TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            this.usuarioLogado = usuarioLogado;
            this.telaPrincipal = telaPrincipal;
            CarregarChamados(usuarioLogado.Id);
        }

        public void CarregarChamados(int idUsuarioLogado)
        {
            string query = "SELECT c.id_chamado AS ID, u.email AS EMAIL_USUARIO, c.descricao AS DESCRICAO, " +
                           "c.categoria AS CATEGORIA, c.prioridade AS PRIORIDADE, c.status AS STATUS, " +
                           "c.data_abertura AS DATA_ABERTURA, c.data_fechamento AS DATA_FECHAMENTO " +
                           "FROM TBChamados AS c " +
                           "INNER JOIN TBUsuarios AS u ON c.id_usuario = u.id_usuario " +
                           "WHERE c.id_usuario = @idUsuario;";

            using (SqlConnection con = banco.AbrirConexao())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@idUsuario", idUsuarioLogado);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void UserChamados_Load(object sender, EventArgs e)
        {

        }

        private void buttonChamado_Click(object sender, EventArgs e)
        {
            telaPrincipal.LoadForm(new UserChamadosNovos(usuarioLogado));
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            telaPrincipal.LoadForm(new UserControlChamados(usuarioLogado, telaPrincipal));
        }
    }
}
