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

namespace GerenciadorJogos
{
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
        }

        private void FormTeste_Load(object sender, EventArgs e)
        {
            cboConsole.DataSource = Enum.GetValues(typeof(TipoConsole)); //Adiciona o enum de console na combobox console
            cboGenero.DataSource = Enum.GetValues(typeof(TipoGenero)); //Adiciona o enum de gênero na combobox gênero
        }

        private void btnListarJogos_Click(object sender, EventArgs e)
        {
            if (ckbListarTodos.CheckState == CheckState.Unchecked)
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
                string select = "SELECT codigo, nome, descricao FROM dbo.Jogos WHERE console = '" + idConsole + "' AND genero = '" + idGenero + "'";  
                SqlCommand cmd = new SqlCommand(select, conn);
                cmd.CommandType = CommandType.Text;
                conn.Close();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable jogos = new DataTable();
                da.Fill(jogos);
                dataGridView1.DataSource = jogos; //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING
            }
            else
            {
                //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UEQIVQ6;Initial Catalog=master;Integrated Security=True");
                SqlConnection conn = new SqlConnection("Data Source=BUE205D002;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
                conn.Open();
                string select = "SELECT codigo, nome, descricao, console, genero FROM dbo.Jogos";
                SqlCommand cmd = new SqlCommand(select, conn);
                cmd.CommandType = CommandType.Text;
                conn.Close();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable jogos = new DataTable();
                da.Fill(jogos);
                dataGridView1.DataSource = jogos; //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING //CONVERTER NUMERO PARA STRING
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
