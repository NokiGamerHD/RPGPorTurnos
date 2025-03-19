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

                Itens Equips = new Itens();
                Equips.cadastrarItem();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}