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
    public partial class INATIVOFormListarLISTA : Form
    {
        public INATIVOFormListarLISTA()
        {
            InitializeComponent();
        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            cboConsole.DataSource = Enum.GetValues(typeof(TipoConsole)); //Adiciona o enum de console na combobox console
            cboGenero.DataSource = Enum.GetValues(typeof(TipoGenero)); //Adiciona o enum de gênero na combobox gênero
        }

        private void btnListarJogos_Click(object sender, EventArgs e)
        {
            lstDados.Items.Clear();
            if (cboConsole.Text != "" && cboGenero.Text != "" && ckbListarTodos.CheckState == CheckState.Unchecked)
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
                SqlConnection conn = new SqlConnection("Data Source=BUE205D002;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
                conn.Open();
                string select = "SELECT * FROM dbo.Jogos WHERE console = '" + idConsole + "' AND genero = '" + idGenero + "'";
                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lstDados.Items.Add("Nome: " + dr["nome"]);
                    lstDados.Items.Add("Descricao: " + dr["descricao"]);
                    lstDados.Items.Add("Código: " + dr["codigo"]);
                    lstDados.Items.Add("Console: " + ((TipoConsole)dr["console"])); //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING
                    lstDados.Items.Add("Gênero: " + ((TipoGenero)dr["genero"])); //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING
                    lstDados.Items.Add("///////////////////////////");
                }
                conn.Close();
            }                     
            if (ckbListarTodos.CheckState == CheckState.Checked)
            {
                //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UEQIVQ6;Initial Catalog=master;Integrated Security=True");
                SqlConnection conn = new SqlConnection("Data Source=BUE205D002;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
                conn.Open();
                string select = "SELECT * FROM dbo.Jogos";
                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lstDados.Items.Add("Nome: " + dr["nome"]);
                    lstDados.Items.Add("Descricao: " + dr["descricao"]);
                    lstDados.Items.Add("Código: " + dr["codigo"]);
                    lstDados.Items.Add("Console: " + ((TipoConsole)dr["console"])); //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING
                    lstDados.Items.Add("Gênero: " + ((TipoGenero)dr["genero"])); //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING
                    lstDados.Items.Add("///////////////////////////");
                }
                conn.Close();
            }
        }

        private void ckbListarTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbListarTodos.CheckState == CheckState.Checked)
            {
                cboConsole.Enabled = false;
                cboGenero.Enabled = false;
            }
            else
            {
                cboConsole.Enabled = true;
                cboGenero.Enabled = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormPrincipal newFormPrincipal = new FormPrincipal();
            newFormPrincipal.Show();
            this.Visible = false;
        }
    }
}
