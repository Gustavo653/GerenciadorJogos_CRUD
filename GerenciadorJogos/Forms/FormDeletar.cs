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
    public partial class FormDeletar : Form
    {
        public FormDeletar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormPrincipal newFormPrincipal = new FormPrincipal();
            this.Visible = false; ;
            newFormPrincipal.Show();
        }
        private void btnRemoverJogo_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=BUE205D002;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
            string delete = "DELETE from dbo.Jogos WHERE nome = '" + cboNome.Text + "' AND codigo = '" + cboCodigo.Text + "'";
            SqlCommand cmd = new SqlCommand(delete, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Jogo removido com sucesso!", "Jogo removido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormPrincipal newFormPrincipal = new FormPrincipal();
            this.Visible = false; ;
            newFormPrincipal.Show();
        }

        private void FormDeletar_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Para remover um jogo, insira o nome e/ou o código.", "Instruções", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<int> codigos = new List<int>();
            List<string> nomes = new List<string>();
            SqlConnection conn = new SqlConnection("Data Source=BUE205D002;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
            conn.Open();
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
    }
}
