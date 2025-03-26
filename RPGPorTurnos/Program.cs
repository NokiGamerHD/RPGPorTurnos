using System;
using System.Configuration;

namespace RPGPorTurnos
{
    class Program
    {
        static void Main(string[] args)
        {

            string opc;
            Console.WriteLine("Bem Vindo!");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Começar o Jogo");
            Console.WriteLine("2 - Sair");
            Console.WriteLine(" ");
            opc = Console.ReadLine();
            if (opc == "1")
            {
                Personagem Char = new Personagem();
                Char.criacaoPersonagem();

                Console.WriteLine("");
                Console.Clear();

                Itens Item = new Itens();
                Item.cadastrarItem();

                Console.WriteLine("");
                Console.Clear();

                Mapa local = new Mapa();
                local.cidadeCentral();

                Console.WriteLine("");
                Console.Clear();

            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}