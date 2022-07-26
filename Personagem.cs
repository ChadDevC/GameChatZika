using System;
using System.Collections.Generic;
using System.Text;

namespace GameChatZika
{
    public class Personagem
    {

        public string Nome { get; set; }
        public decimal Exp { get; set; }



        public int Classe { get; set; }
        public int Linhagem { get; set; }
        public int CidadeNatal { get; set; }
        public int CidadeAtual { get; set; }

        public int Level
        {
            get
            {
                int nivel = 1;
                if (Exp > 100) { nivel = 2; }
                if (Exp > 200) { nivel = 3; }
                if (Exp > 300) { nivel = 4; }


                int level = nivel;
                return level;

            }

        }

        public Personagem() { }

        public Personagem(
        string Nome,
        decimal Exp,
        int Classe,
        int Linhagem,
        int CidadeNatal,
        int CidadeAtual)
        {
            this.Nome = Nome;
            this.Exp = Exp;
            this.Classe = Classe;
            this.Linhagem = Linhagem;
            this.CidadeNatal = CidadeNatal;
            this.CidadeAtual = CidadeAtual;
        }
    }
}
