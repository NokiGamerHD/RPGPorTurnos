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
            equipamentos[0, 3] = "DANO/CURA/BÔNUS";
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
            equipamentos[5, 5] = "Corpo a Corpo";
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

            equipamentos[9, 0] = "Poção de Força";
            equipamentos[9, 1] = "Consumível";
            equipamentos[9, 2] = "5";
            equipamentos[9, 3] = "+5 de Ataque Físico/Distância (Bônus)";
            equipamentos[9, 4] = "0";
            equipamentos[9, 5] = "Corpo a Corpo (Consurmir)/Curto (Arremessar)";
            equipamentos[9, 6] = "1";
            equipamentos[9, 7] = "Sem Classe";

            equipamentos[10, 0] = "Poção de Força Grande";
            equipamentos[10, 1] = "Consumível";
            equipamentos[10, 2] = "15";
            equipamentos[10, 3] = "+20 de Ataque Físico/Distância (Bônus)";
            equipamentos[10, 4] = "0";
            equipamentos[10, 5] = "Corpo a Corpo (Consurmir)/Curto (Arremessar)";
            equipamentos[10, 6] = "1";
            equipamentos[10, 7] = "Sem Classe";

            equipamentos[11, 0] = "Poção de Mana";
            equipamentos[11, 1] = "Consumível";
            equipamentos[11, 2] = "5";
            equipamentos[11, 3] = "+5 de Ataque Mágico (Bônus)";
            equipamentos[11, 4] = "0";
            equipamentos[11, 5] = "Corpo a Corpo (Consurmir)/Curto (Arremessar)";
            equipamentos[11, 6] = "1";
            equipamentos[11, 7] = "Mago/Bardo";

            equipamentos[12, 0] = "Poção de Mana Grande";
            equipamentos[12, 1] = "Consumível";
            equipamentos[12, 2] = "15";
            equipamentos[12, 3] = "+20 de Ataque Mágico (Bônus)";
            equipamentos[12, 4] = "0";
            equipamentos[12, 5] = "Corpo a Corpo (Consurmir)/Curto (Arremessar)";
            equipamentos[12, 6] = "1";
            equipamentos[12, 7] = "Mago/Bardo";

            equipamentos[13, 0] = "Aljava de Flechas";
            equipamentos[13, 1] = "Munição";
            equipamentos[13, 2] = "5";
            equipamentos[13, 3] = "5 (Arremessar/Sem Arco)";
            equipamentos[13, 4] = "0";
            equipamentos[13, 5] = "Médio (Arremessar/Sem Arco)";
            equipamentos[13, 6] = "2";
            equipamentos[13, 7] = "Sem Classe/Arqueiro";

            equipamentos[14, 0] = "Armadura de Prata";
            equipamentos[14, 1] = "Armadura";
            equipamentos[14, 2] = "30";
            equipamentos[14, 3] = "0";
            equipamentos[14, 4] = "30";
            equipamentos[14, 5] = "Nenhuma";
            equipamentos[14, 6] = "15";
            equipamentos[14, 7] = "Guerreiro";

            equipamentos[15, 0] = "Manto da Visão";
            equipamentos[15, 1] = "Armadura";
            equipamentos[15, 2] = "30";
            equipamentos[15, 3] = "+15 de Ataque Físico/Distância (Bônus)";
            equipamentos[15, 4] = "15";
            equipamentos[15, 5] = "Nenhuma";
            equipamentos[15, 6] = "5";
            equipamentos[15, 7] = "Arqueiro";

            equipamentos[16, 0] = "Tûnica Arcana";
            equipamentos[16, 1] = "Armadura";
            equipamentos[16, 2] = "30";
            equipamentos[16, 3] = "+20 de Ataque Mágico (Bônus)";
            equipamentos[16, 4] = "10";
            equipamentos[16, 5] = "Nenhuma";
            equipamentos[16, 6] = "10";
            equipamentos[16, 7] = "Mago";

            equipamentos[17, 0] = "Kimono de Luta";
            equipamentos[17, 1] = "Armadura";
            equipamentos[17, 2] = "30";
            equipamentos[17, 3] = "+15 de Ataque Físico (Bônus)";
            equipamentos[17, 4] = "15";
            equipamentos[17, 5] = "Nenhuma";
            equipamentos[17, 6] = "5";
            equipamentos[17, 7] = "Monge";

            equipamentos[18, 0] = "Uniforme de Maestro";
            equipamentos[18, 1] = "Armadura";
            equipamentos[18, 2] = "30";
            equipamentos[18, 3] = "+15 de Ataque Mágico/+10 de Ataque Físico (Bônus)";
            equipamentos[18, 4] = "5";
            equipamentos[18, 5] = "Nenhuma";
            equipamentos[18, 6] = "5";
            equipamentos[18, 7] = "Bardo";

            equipamentos[19, 0] = "Capuz das Trevas";
            equipamentos[19, 1] = "Armadura";
            equipamentos[19, 2] = "30";
            equipamentos[19, 3] = "+20 de Ataque Físico (Bônus)";
            equipamentos[19, 4] = "10";
            equipamentos[19, 5] = "Nenhuma";
            equipamentos[19, 6] = "5";
            equipamentos[19, 7] = "Ladino";

            equipamentos[20, 0] = "Zênite";
            equipamentos[20, 1] = "Arma";
            equipamentos[20, 2] = "480153.98";
            equipamentos[20, 3] = "314159265359";
            equipamentos[20, 4] = "0";
            equipamentos[20, 5] = "Médio";
            equipamentos[20, 6] = "2";
            equipamentos[20, 7] = "Guerreiro";


            listarItens();
        }

        public void listarItens()
        {
            Console.WriteLine("EQUIPAMENTOS:");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(equipamentos);
            Console.ReadKey();
            Console.Clear();


        }
    }
}
