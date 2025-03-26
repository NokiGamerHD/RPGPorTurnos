using System;
using System.Collections.Generic;
using System.Text;

namespace RPGPorTurnos
{
    public class Mapa
    {
        string opcao;
        string local;
        private Random random = new Random();
        private int num;

        public void cidadeCentral()
        {
            num = random.Next(1, 101);

            do

            {
                Console.WriteLine("Bem Vindo!");
                Console.WriteLine("Você chegou a CIDADE CENTRAL!");
                Console.WriteLine("");
                Console.WriteLine("Selecione o Local que você deseja viajar:");
                Console.WriteLine("1 - CIDADE NA FLORESTA");
                Console.WriteLine("2 - PORTO");
                Console.WriteLine("3 - DESERTO SEM FIM");
                Console.WriteLine("4 - MINAS ESQUECIDAS");
                Console.WriteLine("");
                opcao = Console.ReadLine();
            } while (opcao != "CIDADE NA FLORESTA" && opcao != "PORTO" && opcao != "DESERTO SEM FIM" && opcao != "MINAS ESQUECIDAS");

            Console.Clear();

            if (opcao == "CIDADE NA FLORESTA")
            {
                cidadeNaFloresta();
                Console.ReadKey();
            }
            else if (opcao == "PORTO")
            {
                porto();
                Console.ReadKey();
            }
            else if (opcao == "DESERTO SEM FIM")
            {
                desertoSemFim();
                Console.ReadKey();
            }
            else
            {
                minasEsquecidas();
                Console.ReadKey();
            }

            Console.Clear();

        }

        public void cidadeNaFloresta()
        {
            string local = "CIDADE NA FLORESTA";
            do
            {
                Console.WriteLine("Bem Vindo!");
                Console.WriteLine("Você chegou a " + local + "!");
                Console.WriteLine("");
                Console.WriteLine("Selecione o Local que você deseja viajar:");
                Console.WriteLine("1 - CIDADE CENTRAL");
                Console.WriteLine("2 - MINAS ESQUECIDAS");
                Console.WriteLine("");
                opcao = Console.ReadLine();
            } while (opcao != "CIDADE CENTRAL" && opcao != "MINAS ESQUECIDAS");

            Console.Clear();

            if (opcao == "CIDADE CENTRAL")
            {
                cidadeCentral();
                Console.ReadKey();
            }
            else
            {
                minasEsquecidas();
                Console.ReadKey();
            }

        }

        public void minasEsquecidas()
        {
            local = "MINAS ESQUECIDAS";
            num = random.Next(1, 101);
            if (num <= 75)
            {
                Console.WriteLine("Bem Vindo!");
                Console.WriteLine("Você chegou a " + local + "!");
                Console.WriteLine("");
                Console.WriteLine("Oh não!");
                Console.WriteLine("Você encontrou uma ARANHA GIGANTE!");
                Console.WriteLine("");
                Console.WriteLine("Quer voltar para a CIDADE CENTRAL?");
                Console.WriteLine("1 - SIM");
                Console.WriteLine("2 - NÃO");
                Console.WriteLine("");
                opcao = Console.ReadLine();
                if (opcao == "1")
                {
                    Console.Clear();
                    cidadeCentral();
                }
                else
                {
                    Console.Clear();
                    Environment.Exit(0);
                }

            }
            else
            {


                do
                {

                    Console.WriteLine("Bem Vindo!");
                    Console.WriteLine("Você chegou a " + local + "!");
                    Console.WriteLine("");
                    Console.WriteLine("Selecione o Local que você deseja viajar:");
                    Console.WriteLine("1 - CIDADE NA FLORESTA");
                    Console.WriteLine("2 - CIDADE CENTRAL");
                    Console.WriteLine("");
                    opcao = Console.ReadLine();

                } while (opcao != "CIDADE NA FLORESTA" && opcao != "CIDADE CENTRAL");

                Console.Clear();

                if (opcao == "CIDADE NA FLORESTA")
                {
                    cidadeNaFloresta();
                    Console.ReadKey();
                }
                else
                {
                    cidadeCentral();
                    Console.ReadKey();
                }
            }

        }

        public void porto()
        {
            local = "PORTO";
            num = random.Next(1, 101);
            if (num <= 50)
            {
                Console.WriteLine("Bem Vindo!");
                Console.WriteLine("Você chegou a " + local + "!");
                Console.WriteLine("");
                Console.WriteLine("Oh não!");
                Console.WriteLine("Você encontrou um BANDIDO!");
                Console.WriteLine("");
                Console.WriteLine("Quer voltar para a CIDADE CENTRAL?");
                Console.WriteLine("1 - SIM");
                Console.WriteLine("2 - NÃO");
                Console.WriteLine("");
                opcao = Console.ReadLine();
                if (opcao == "1")
                {
                    Console.Clear();
                    cidadeCentral();
                }
                else
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
            }
            else
            {
                do
                {
                    Console.WriteLine("Bem Vindo!");
                    Console.WriteLine("Você chegou a " + local + "!");
                    Console.WriteLine("");
                    Console.WriteLine("Selecione o Local que você deseja viajar:");
                    Console.WriteLine("1 - CIDADE CENTRAL");
                    Console.WriteLine("2 - ILHA SOLITÁRIA");
                    Console.WriteLine("");
                    opcao = Console.ReadLine();

                } while (opcao != "CIDADE CENTRAL" && opcao != "ILHA SOLITÁRIA");

                Console.Clear();

                if (opcao == "CIDADE CENTRAL")
                {
                    cidadeCentral();
                    Console.ReadKey();
                }
                else
                {
                    ilhaSolitaria();
                    Console.ReadKey();
                }
            }
        }

        public void ilhaSolitaria()
        {
            local = "ILHA SOLITÁRIA";
            num = random.Next(1, 101);
            if (num <= 50)
            {
                Console.WriteLine("Bem Vindo!");
                Console.WriteLine("Você chegou a " + local + "!");
                Console.WriteLine("");
                Console.WriteLine("Oh não!");
                Console.WriteLine("Você encontrou um QUARA!");
                Console.WriteLine("");
                Console.WriteLine("Quer voltar para o PORTO?");
                Console.WriteLine("1 - SIM");
                Console.WriteLine("2 - NÃO");
                Console.WriteLine("");
                opcao = Console.ReadLine();
                if (opcao == "1")
                {
                    Console.Clear();
                    porto();
                }
                else
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
            }
            else
            {
                do
                {
                    Console.WriteLine("Bem Vindo!");
                    Console.WriteLine("Você chegou a " + local + "!");
                    Console.WriteLine("");
                    Console.WriteLine("Selecione o Local que você deseja viajar:");
                    Console.WriteLine("1 - PORTO");
                    Console.WriteLine("");
                    opcao = Console.ReadLine();

                } while (opcao != "PORTO");

                Console.Clear();

                porto();
                Console.ReadKey();
            }
              
        }

        public void desertoSemFim()
        {
            local = "DESERTO SEM FIM";
            num = random.Next(1, 101);
            if (num <= 25)
            {
                Console.WriteLine("Bem Vindo!");
                Console.WriteLine("Você chegou a " + local + "!");
                Console.WriteLine("");
                Console.WriteLine("Oh não!");
                Console.WriteLine("Você encontrou um ESCORPIÃO!");
                Console.WriteLine("");
                Console.WriteLine("Quer voltar para a CIDADE CENTRAL?");
                Console.WriteLine("1 - SIM");
                Console.WriteLine("2 - NÃO");
                Console.WriteLine("");
                opcao = Console.ReadLine();
                if (opcao == "1")
                {
                    Console.Clear();
                    cidadeCentral();
                }
                else
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
            }
            else
            {
                do
                {
                    Console.WriteLine("Bem Vindo!");
                    Console.WriteLine("Você chegou a " + local + "!");
                    Console.WriteLine("");
                    Console.WriteLine("Selecione o Local que você deseja viajar:");
                    Console.WriteLine("1 - CIDADE CENTRAL");
                    Console.WriteLine("");
                    opcao = Console.ReadLine();

                } while (opcao != "CIDADE CENTRAL");

                Console.Clear();

                cidadeCentral();
                Console.ReadKey();
            }
                   
        }
    }
}
