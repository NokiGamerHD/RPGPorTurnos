using System;
using System.Collections.Generic;
using System.Text;

namespace RPGPorTurnos
{
    public class Itens
    {
        string[,] equipamentos = new string[21, 8];
        public void cadastrarItem()
        {
            equipamentos[0, 0] = "ITEM";
            equipamentos[0, 1] = "TIPO";
            equipamentos[0, 2] = "VALOR";
            equipamentos[0, 3] = "DANO/CURA";
            equipamentos[0, 4] = "DEFESA";
            equipamentos[0, 5] = "ALCANCE";
            equipamentos[0, 6] = "SLOTS";
            equipamentos[0, 7] = "CLASSE";

            equipamentos[1, 0] = "Espada";
            equipamentos[1, 1] = "Arma";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "15 Dano";
            equipamentos[1, 4] = "0";
            equipamentos[1, 5] = "Corpo a Corpo";
            equipamentos[1, 6] = "1 (Uma Mão)";
            equipamentos[1, 7] = "Guerreiro";

            equipamentos[2, 0] = "Arco";
            equipamentos[2, 1] = "Arma";
            equipamentos[2, 2] = "20";
            equipamentos[2, 3] = "10 Dano";
            equipamentos[2, 4] = "0";
            equipamentos[2, 5] = "Longo";
            equipamentos[2, 6] = "2 (Duas Mãos)";
            equipamentos[2, 7] = "Arqueiro";

            equipamentos[3, 0] = "Cajado";
            equipamentos[3, 1] = "Arma";
            equipamentos[3, 2] = "30";
            equipamentos[3, 3] = "20 Dano";
            equipamentos[3, 4] = "0";
            equipamentos[3, 5] = "Médio";
            equipamentos[3, 6] = "2 (Duas Mãos)";
            equipamentos[3, 7] = "Mago";

            equipamentos[4, 0] = "Cestus";
            equipamentos[4, 1] = "Arma";
            equipamentos[4, 2] = "10";
            equipamentos[4, 3] = "15";
            equipamentos[4, 4] = "0";
            equipamentos[4, 5] = "Corpo a Corpo";
            equipamentos[4, 6] = "2 (Duas Mãos)";
            equipamentos[4, 7] = "Monge";

            equipamentos[5, 0] = "Violino ou Flauta";
            equipamentos[5, 1] = "Instrumento/Arma";
            equipamentos[5, 2] = "15";
            equipamentos[5, 3] = "15 Cura";
            equipamentos[5, 4] = "0";
            equipamentos[5, 5] = "Curto";
            equipamentos[5, 6] = "2 (Duas Mãos)";
            equipamentos[5, 7] = "Sem Classe/Bardo";

            equipamentos[6, 0] = "Adaga";
            equipamentos[6, 1] = "Arma";
            equipamentos[6, 2] = "10";
            equipamentos[6, 3] = "15";
            equipamentos[6, 4] = "0";
            equipamentos[6, 5] = "Corpo a Corpo";
            equipamentos[6, 6] = "1 (Uma Mão)";
            equipamentos[6, 7] = "Ladino/Bardo";

            equipamentos[7, 0] = "Poção de Cura";
            equipamentos[7, 1] = "Consumível";
            equipamentos[7, 2] = "5";
            equipamentos[7, 3] = "30 Cura";
            equipamentos[7, 4] = "0";
            equipamentos[7, 5] = "Corpo a Corpo (Consurmir)/Curto (Arremessar)";
            equipamentos[7, 6] = "1";
            equipamentos[7, 7] = "Sem Classe";

            equipamentos[8, 0] = "Poção de Cura Grande";
            equipamentos[8, 1] = "Consumível";
            equipamentos[8, 2] = "15";
            equipamentos[8, 3] = "100 Cura";
            equipamentos[8, 4] = "0";
            equipamentos[8, 5] = "Corpo a Corpo (Consurmir)/Curto (Arremessar)";
            equipamentos[7, 6] = "1";
            equipamentos[7, 7] = "Sem Classe";

            listarItens();
        }

        public void listarItens()
        {
            Console.WriteLine(equipamentos);
        }
    }
}
