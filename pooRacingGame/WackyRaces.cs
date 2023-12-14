using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pooRacingGame
{
    class WackyRaces
    {
        static void Main()
        {
            Boolean ganhou = false;
            string resp = "y";
            int aposta = 0;
            int ganhador = 0;

            // Configura o tamanho da pistas e o nome do correr
            while (resp == "y")
            {
                Pista pista1 = new Pista(230, new Corredor("¬O=°-o>"));
                Pista pista2 = new Pista(230, new Corredor("¬O=°-o>"));
                Pista pista3 = new Pista(230, new Corredor("¬O=°-o>"));
                Pista pista4 = new Pista(230, new Corredor("¬O=°-o>"));
                Pista pista5 = new Pista(230, new Corredor("¬O=°-o>"));
                Pista pista6 = new Pista(230, new Corredor("¬O=°-o>"));
                Pista pista7 = new Pista(230, new Corredor("¬O=°-o>"));
                Pista pista8 = new Pista(230, new Corredor("¬O=°-o>"));
                Pista pista9 = new Pista(230, new Corredor("¬O=°-o>"));
                Pista pista10 = new Pista(230, new Corredor("¬O=°-o>"));
                Pista pista11 = new Pista(230, new Corredor("¬O=°-o>"));
                Pista pista12 = new Pista(230, new Corredor("¬O=°-o>"));
                Pista pista13 = new Pista(230, new Corredor("¬O=°-o>"));
                Pista pista14 = new Pista(230, new Corredor("¬O=°-o>"));
                Pista pista15 = new Pista(230, new Corredor("¬O=°-o>"));
                Pista pista16 = new Pista(230, new Corredor("¬O=°-o>"));

                Console.Clear();
                Console.WriteLine(" $#@ - Wacky Races - @#$");
               
                // Mostar quem ta correndo
                Console.WriteLine(" Rancers: " +
                    "\n 1 - Máquina Malvada 00 - Dick Vigarista e  Muttley (1)" +
                    "\n 2 - Carro de Pedra 01 - Irmãos Rocha (2)" +
                    "\n 3 - Cupê Mal-Assombrado 02 - Medonho e Medinho (3)" +
                    "\n 4 - Carro Mágico 03 - Professor Aéreo (4)" +
                    "\n 5 - Maquina Voadora 04 - Barão Vermelho (5)" +
                    "\n 6 - Carrinho pra frente 05 -  Penélope Charmosa (6)" +
                    "\n 7 - Carro Tanque 06 - Soldado Meekley e Sargento Bombarda (7)" +
                    "\n 8 - Carro-à-Prova de Balas 07 - Quadrilha de Morte (8)" +
                    "\n 9 - Carroça a Vapor 08 - Tio Tomás e Chorão (9)" +
                    "\n 10 - Carrão Aerodinâmico 09 - Peter Perfeito (10)" +
                    "\n 11 - Carro-Tronco 10 - Rufus Lenhador e Dentes-de-Serra (11)" +
                    "\n 12 - Honda NSX Type R 11 - Ayrton Senna (12)" +
                    "\n 13 - Opala BiTurbo V12 - Jujubinha (13)" +
                    "\n 14 - Uno BiTurbo V16 - Mumuzinho (14)" +
                    "\n 15 - Chevette Godzilla - Cadu Moreira (15)" +
                    "\n 16 - Hot Rod Boat - Bob Esponja e Patrick (16)");
                 
                // Cria uma variavel para as apostas
                Console.Write(" Which runner do you bet on (|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|): ");
                aposta = Convert.ToInt32(Console.ReadLine());
                ganhador = 0;
                ganhou = false;
                while (ganhou == false)
                {
                    Console.Clear();
                    if (pista1.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 1;
                    }
                    if (pista2.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 2;
                    }
                    if (pista3.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 3;
                    }
                    if (pista4.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 4;
                    }
                    if (pista5.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 5;
                    }
                    if (pista6.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 6;
                    }
                    if (pista7.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 7;
                    }
                    if (pista8.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 8;
                    }
                    if (pista9.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 9;
                    }
                    if (pista10.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 10;
                    }
                    if (pista11.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 11;
                    }
                    if (pista12.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 12;
                    }
                    if (pista13.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 13;
                    }
                    if (pista14.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 14;
                    }
                    if (pista15.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 15;
                    }
                    if (pista16.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 16;
                    }

                    // Exibe a pista
                    pista1.ExibirPista();
                    pista2.ExibirPista();
                    pista3.ExibirPista();
                    pista4.ExibirPista();
                    pista5.ExibirPista();
                    pista6.ExibirPista();
                    pista7.ExibirPista();
                    pista8.ExibirPista();
                    pista9.ExibirPista();
                    pista10.ExibirPista();
                    pista11.ExibirPista();
                    pista12.ExibirPista();
                    pista13.ExibirPista();
                    pista14.ExibirPista();
                    pista15.ExibirPista();
                    pista16.ExibirPista();
                    Thread.Sleep(500);
                }
                Console.Clear();
                Console.WriteLine(" $#@ - Wacky Races - @#$");
                Console.WriteLine($" The winner was the number runner {ganhador}");
                switch (ganhador)
                
                // Variavel do ganhador
                {
                    case 1:
                        Console.WriteLine(" Dick Vigarista e  Muttley");
                        break;
                    case 2:
                        Console.WriteLine(" Irmãos Rocha");
                        break;
                    case 3:
                        Console.WriteLine(" Medonho e Medinho");
                        break;
                    case 4:
                        Console.WriteLine(" Professor Aéreo");
                        break;
                    case 5:
                        Console.WriteLine(" Barão Vermelho");
                        break;
                    case 6:
                        Console.WriteLine(" Penélope Charmosa");
                        break;
                    case 7:
                        Console.WriteLine(" Soldado Meekley e Sargento Bombarda");
                        break;
                    case 8:
                        Console.WriteLine(" Quadrilha de Morte");
                        break;
                    case 9:
                        Console.WriteLine(" Tio Tomás e Chorão");
                        break;
                    case 10:
                        Console.WriteLine("Peter Perfeito");
                        break;
                    case 11:
                        Console.WriteLine(" Rufus Lenhador e Dentes-de-Serra");
                        break;
                    case 12:
                        Console.WriteLine(" Ayrton Senna");
                        break;
                    case 13:
                        Console.WriteLine(" Jujubinha");
                        break;
                    case 14:
                        Console.WriteLine(" Mumuzinho");
                        break;
                    case 15:
                        Console.WriteLine(" Cadu Moreira");
                        break;
                    case 16:
                        Console.WriteLine(" Bob Esponja e Patrick");
                        break;
                }
                if (ganhador == aposta)
                {
                    Console.WriteLine(" $#@ - Congratulations!!!! You Win!!!! - @#$");
                }
                else
                {
                    Console.WriteLine(" $#@ - What a Shame !!!! You Lost!!!! - @#$");
                }
                Console.Write(" Play again Y ou N: ");
                resp = Console.ReadLine().ToLower();
            }
        }
    }
}



