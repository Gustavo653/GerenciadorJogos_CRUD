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
    public partial class FormAlterar : Form
    {
        public FormAlterar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormPrincipal newFormPrincipal = new FormPrincipal();
            this.Visible = false; ;
            newFormPrincipal.Show();
        }

        private void FormAlterar_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Para atualizar o dado de algum jogo, insira seu código e clique em outro campo, para atualizar os dados.\nQuando aparecer os dados atuais, basta sobreescreve-los.", "Instruções", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboConsole.DataSource = Enum.GetValues(typeof(TipoConsole)); //Adiciona o enum de console na combobox console
            cboGenero.DataSource = Enum.GetValues(typeof(TipoGenero)); //Adiciona o enum de gênero na combobox gênero
        }

        private void btnAlterarJogo_Click(object sender, EventArgs e)
        {
            int idConsole = 0, idGenero = 0;
            for (int i = 0; i < 5; i++)
            {
                if (cboConsole.Text == ((TipoConsole)i).ToString()) //Substitui o console pelo enum do console
                {
                    idConsole = i;
                    break;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                if (cboGenero.Text == ((TipoGenero)i).ToString()) //Substitui o genero pelo enum do genero
                {
                    idGenero = i;
                    break;
                }
            }
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UEQIVQ6;Initial Catalog=master;Integrated Security=True");
            //SqlConnection conn = new SqlConnection("Data Source=BUE205D002;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021"); 
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gustavo.silva22\Desktop\GerenciadorJogos_CRUD\GerenciadorJogos\BD\bd.mdf;Integrated Security=True");
            string update = "UPDATE dbo.Jogos Set nome = '" + txtNome.Text + "', descricao = '" + txtDescricao.Text + "', console = '" + idConsole + "', genero = '" + idGenero + "' WHERE codigo = '" + txtCodigo.Text + "'";
            SqlCommand cmd = new SqlCommand(update, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UEQIVQ6;Initial Catalog=master;Integrated Security=True");
            //SqlConnection conn = new SqlConnection("Data Source=BUE205D002;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021"); conn.Open();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gustavo.silva22\Desktop\GerenciadorJogos_CRUD\GerenciadorJogos\BD\bd.mdf;Integrated Security=True");
            string select = "SELECT codigo, nome, descricao, console, genero FROM dbo.Jogos WHERE codigo = '" + txtCodigo.Text + "'";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtNome.Text = dr["nome"].ToString();
                txtDescricao.Text = dr["descricao"].ToString();
                cboConsole.SelectedIndex = (Convert.ToInt32(dr["console"]));
                cboGenero.SelectedIndex = Convert.ToInt32(dr["genero"]);
            }
            conn.Close();
        }
    }
}
