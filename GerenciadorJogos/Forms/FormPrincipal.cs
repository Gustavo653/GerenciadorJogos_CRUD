using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using GerenciadorJogos.Forms;

namespace GerenciadorJogos
{
    public partial class FormPrincipal : Form
    {
        //Código para criar tabela SQL
        //  Create Table dbo.Jogos
        //(
        // idJogo int not null IDENTITY(1,1),
        // codigo int not null,
        // nome varchar(100),
        // descricao varchar(max),
        // console int not null,
        // genero int not null
        //)

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false; //Oculta o formulário
            MessageBox.Show("Obrigado por usar nosso programa :D", "Volte sempre!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void btnInstrucoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("▶ Seja bem vindo ao gerenciador de jogos. ◀" +
                "\n●O que você pode fazer: " +
                "\n•Cadastrar um jogo" +
                "\n•Excluir um jogo" +
                "\n•Alterar um jogo" +
                "\n•Localizar um jogo por nome" +
                "\n•Listar todos os jogos" +
                "\n•Listar todos os jogos por gênero" +
                "\n•Listar todos os jogos por console", "Instruções", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string escolha = cboOpcoes.Text;
            if (escolha == "Cadastrar")
            {
                FormCadastrar newFormCadastrar = new FormCadastrar();
                this.Visible = false;
                newFormCadastrar.Show();
            }
            else if (escolha == "Excluir")
            {
                FormDeletar newFormDeletar = new FormDeletar();
                this.Visible = false;
                newFormDeletar.Show();
            }
            else if (escolha == "Alterar")
            {
                FormAlterar newFormAlterar = new FormAlterar();
                this.Visible = false;
                newFormAlterar.Show();
            }
            else if (escolha == "Localizar")
            {
                FormLocalizar newFormLocalizar = new FormLocalizar();
                this.Visible = false;
                newFormLocalizar.Show();
            }
            else if (escolha == "Listar jogos")
            {

            }
            else
            {
                MessageBox.Show("O item escolhido é inválido, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboOpcoes.Text = "";
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            cboOpcoes.SelectedIndex = 0;
        }
    }
}
