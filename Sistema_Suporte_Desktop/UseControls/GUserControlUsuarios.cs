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
    public partial class GUserControlUsuarios : UserControl
    {
        private Banco banco;
        private UserControl activeControl = null;
        private Usuario usuarioLogado;

        public GUserControlUsuarios(Usuario usuario)
        {
            InitializeComponent();
            banco = new Banco();
            CarregarUsuarios();
            this.usuarioLogado = usuario;
        }

        private void GUserControlUsuarios_Load(object sender, EventArgs e)
        {

        }

        public void CarregarUsuarios()
        {
            string query = "SELECT ID_USUARIO AS ID, NOME, EMAIL, TIPO_USUARIO AS TIPO, ATIVO FROM TBUSUARIOS";

            using(SqlConnection con = banco.AbrirConexao())
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
                panelUsuarios.Controls.Remove(activeControl);
                activeControl.Dispose();
            }

            activeControl = newControl;
            newControl.Dock = DockStyle.Fill;
            panelUsuarios.Controls.Add(newControl);

        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            LoadForm(new GUsuarioCadastro(this));
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            LoadForm(new GUsuarioEditado(this));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            LoadForm(new GUsuarioExcluido(this, usuarioLogado));
        }

        private void buttonSenha_Click(object sender, EventArgs e)
        {
            LoadForm(new GUsuarioSenha(this));
        }

        private void buttonTecnico_Click(object sender, EventArgs e)
        {
            LoadForm(new GUsuarioTecnico(this, usuarioLogado));
        }
    }
}
