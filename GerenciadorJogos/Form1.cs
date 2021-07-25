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

namespace GerenciadorJogos
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
        }

    }
}
