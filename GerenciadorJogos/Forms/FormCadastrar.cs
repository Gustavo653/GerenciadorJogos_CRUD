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
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Para adicionar um jogo, basta preencher as informações requisitadas." +
                "\nO campo código é gerado de forma automática e única." +
                "\nQuando terminar, basta clicar no botão 'Adicionar Jogo'", "Instruções", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GerarCodigo();

            cboConsole.DataSource = Enum.GetValues(typeof(TipoConsole)); //Adiciona o enum de console na combobox console
            cboGenero.DataSource = Enum.GetValues(typeof(TipoGenero)); //Adiciona o enum de gênero na combobox gênero
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormPrincipal newFormPrincipal = new FormPrincipal();
            this.Visible = false; ;
            newFormPrincipal.Show();
        }

        private void btnAdicionarJogo_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtDescricao.Text != "")
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
                string insert = "INSERT into dbo.Jogos (codigo, nome, descricao, console, genero) values ('" + txtCodigo.Text + "', '" + txtNome.Text + "', '" + txtDescricao.Text + "', '" + idConsole + "', '" + idGenero + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Jogo adicionado com sucesso!", "Jogo adicionado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormPrincipal newFormPrincipal = new FormPrincipal();
                this.Visible = false; ;
                newFormPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Preencha o campo nome e o campo descrição!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GerarCodigo() //Gera um código não repetido
        {
            Random ran = new Random();
            List<string> codigo = new List<string>();
            codigo.AddRange(ReceberCodigosBD()); //Adiciona a lista de não repetir os códigos já existentes no BD
            while (true)
            {
                bool numeroRepetido = false;
                string numero = ran.Next(0, 10001).ToString();
                if (codigo.Count >= 10000)
                {
                    MessageBox.Show("Remova algum jogo para adicionar um novo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                foreach (var item in codigo)
                {
                    if (item == numero)
                    {
                        numeroRepetido = true;
                    }
                }
                if (!numeroRepetido)
                {
                    codigo.Add(numero);
                    txtCodigo.Text = numero;
                    break;
                }
            }
        }
        private static List<string> ReceberCodigosBD()
        {
            List<string> codigo = new List<string>();
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UEQIVQ6;Initial Catalog=master;Integrated Security=True");
            //SqlConnection conn = new SqlConnection("Data Source=BUE205D002;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gustavo.silva22\Desktop\GerenciadorJogos_CRUD\GerenciadorJogos\BD\bd.mdf;Integrated Security=True");
            conn.Open();
            string select = "SELECT codigo FROM dbo.Jogos";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                codigo.Add(Convert.ToString(dr["codigo"]));
            }
            conn.Close();
            return codigo;
        }
    }
}
