using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorJogos
{
    class Jogo
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Console { get; set; }
        public string Genero { get; set; }

        public Jogo(int codigo, string nome, string descricao, string console, string genero)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Console = console;
            Genero = genero;
        }
    }
}
