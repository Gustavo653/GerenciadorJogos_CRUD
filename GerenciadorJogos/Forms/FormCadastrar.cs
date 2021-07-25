﻿using System;
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
        private void GerarCodigo() //Gera um código não repetido
        {
            Random ran = new Random();
            List<string> codigo = new List<string>();
            codigo.AddRange(ReceberCodigosBD()); //Adiciona a lista de não repetir os códigos já existentes no BD
            while (true)
            {
                bool numeroRepetido = false;
                string numero = ran.Next(0, 10001).ToString();
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
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UEQIVQ6;Initial Catalog=master;Integrated Security=True");
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
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UEQIVQ6;Initial Catalog=master;Integrated Security=True");
                string insert = "INSERT into dbo.Jogos (codigo, nome, descricao, console, genero) values ('" + txtCodigo.Text + "', '" + txtNome.Text + "', '" + txtDescricao.Text + "', '" + idConsole + "', '" + idGenero + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Preencha o campo nome e o campo descrição!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
