using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorJogos.Forms
{
    public partial class FormLocalizar : Form
    {
        public FormLocalizar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormPrincipal newFormPrincipal = new FormPrincipal();
            this.Visible = false; ;
            newFormPrincipal.Show();
        }

        private void FormLocalizar_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Para pesquisar um jogo, selecione o nome.", "Instruções", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<int> codigos = new List<int>();
            List<string> nomes = new List<string>();
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UEQIVQ6;Initial Catalog=master;Integrated Security=True");
            SqlConnection conn = new SqlConnection("Data Source=BUE205D002;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021"); conn.Open();
            string select = "SELECT * FROM dbo.Jogos";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nomes.Add(Convert.ToString(dr["nome"]));
                codigos.Add(Convert.ToInt32(dr["codigo"]));
            }
            conn.Close();
            cboCodigo.DataSource = codigos;
            cboNome.DataSource = nomes;
        }

        private void cboNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigo.SelectedIndex = cboNome.SelectedIndex;
        }

        private void btnBuscarJogo_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UEQIVQ6;Initial Catalog=master;Integrated Security=True");
            SqlConnection conn = new SqlConnection("Data Source=BUE205D002;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
            conn.Open();
            string select = "SELECT * FROM dbo.Jogos WHERE codigo = '" + cboCodigo.Text + "'";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lstDados.Items.Add("Nome: " + dr["nome"]);
                lstDados.Items.Add("Descricao: " + dr["descricao"]);
                lstDados.Items.Add("Código: " + dr["codigo"]);
                lstDados.Items.Add("Console: " + ((TipoConsole)dr["console"]));
                lstDados.Items.Add("Gênero: " + ((TipoGenero)dr["genero"]));
                lstDados.Items.Add("///////////////////////////");
            }
            conn.Close();
        }
    }
}
