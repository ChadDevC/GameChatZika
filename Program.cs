using System;
using System.Collections.Generic;
using System.Linq;

namespace GameChatZika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            List<Personagem> Personagens = new List<Personagem>();






            // dar opções ao usuario
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("\t1 - Criar Personagem ");
            Console.WriteLine("\t2 - Mostrar Ranking ");
            Console.WriteLine("\t3 - Selecionar Personagem ");
            Console.WriteLine("\t4 - Deletar Personagem ");
            Console.WriteLine("\t5 - Sair");
            Console.Write("Sua opção? ");
            int opcao = 0;
            opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao != 5)
            {
                // case em c#
                switch (opcao)
                {
                    case 1:
                        Personagem personagem1 = new Personagem();

                        string nome = "Luiz";
                        decimal exp = 0.0m;
                        int classe = 0;
                        int linhagem = 0;
                        int cidadeNatal = 0;
                        int cidadeAtual = 0;

                        personagem1.Nome = nome;
                        personagem1.Exp = exp;
                        personagem1.Classe = classe;
                        personagem1.Linhagem = linhagem;
                        personagem1.CidadeNatal = cidadeNatal;
                        personagem1.CidadeAtual = cidadeAtual;


                        Personagem personagem2 = new Personagem("Giuliano", 0.0m, 0, 0, 0, 0);
                        Personagem personagem3 = new Personagem("Joao", 5000.0m, 0, 0, 0, 0);


                        Personagens.Add(personagem1);
                        Personagens.Add(personagem2);
                        Personagens.Add(personagem3);
                        break;
                    case 2:
                        foreach (Personagem p in Personagens)
                        {
                            Console.WriteLine(p.Nome + "" + p.Level + " " + p.CidadeAtual);
                        }

                        break;
                    case 3:
                        Personagem personagemEncontrado;
                        personagemEncontrado = EncontrarPersonagem(Personagens, "Joao");

                        Console.WriteLine($"{personagemEncontrado.Nome}, {personagemEncontrado.Level}");
                        break;
                    case 4:
                        Console.WriteLine($"");
                        break;
                }
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("\t1 - Criar Personagem ");
                Console.WriteLine("\t2 - Mostrar Ranking ");
                Console.WriteLine("\t3 - Selecionar Personagem ");
                Console.WriteLine("\t4 - Deletar Personagem ");
                Console.WriteLine("\t5 - Sair");
                Console.Write("Sua opção? ");
                opcao = Convert.ToInt32(Console.ReadLine());
            }

        }



        public static void MostrarPersonagem(Personagem Personagens)
        {
            Console.WriteLine("Nome: " + Personagens.Nome);
            Console.WriteLine("Exp: " + Personagens.Exp);
            Console.WriteLine("Level: " + Personagens.Level);
            Console.WriteLine("Classe: " + Personagens.Classe);
            Console.WriteLine("Linhagem: " + Personagens.Linhagem);
            Console.WriteLine("CidadeNatal: " + Personagens.CidadeNatal);
            Console.WriteLine($"CidadeAtual:  {Personagens.CidadeAtual} ");

        }


        static Personagem EncontrarPersonagem(List<Personagem> personagens, string nome)
        {
            Personagem personagem = null;
            for (int i = 0; i < personagens.Count; i++)
            {
                if (personagens[i].Nome == nome)
                {
                    personagem = personagens[i];
                }
            }
            return personagem;
        }
    }
}
