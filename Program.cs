using System;

namespace Jokenpo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random jokenpo = new Random();
            int npcPick = jokenpo.Next(1, 4);
            string[] npcChoose = { "", "Pedra", "Tesoura", "Papel" };

            Console.WriteLine("Iremos jogar pedra, papel e tesoura");
            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1. Pedra");
            Console.WriteLine("2. Tesoura");
            Console.WriteLine("3. Papel");

            string playerPick = Console.ReadLine();
            Int32.TryParse(playerPick, out int playerChoose);



            if (playerChoose > 0 && playerChoose <= 3)
            {
                if (playerChoose == 1 && npcPick == 2 || playerChoose == 2 && npcPick == 3
                || playerChoose == 3 && npcPick == 1)
                {
                    Console.WriteLine($"O NPC escolheu {npcChoose[npcPick]}, você ganhou!");
                }

                else if (playerChoose == npcPick)
                {
                    Console.WriteLine($"Os dois escolheram {npcChoose[npcPick]}, vocês empataram!");
                }
                else
                {
                    Console.WriteLine($"O NPC escolheu {npcChoose[npcPick]}, você perdeu!");
                }
            }
            else
            {
                Console.WriteLine("Você precisa inserir uma opção válida");
            }
           // Console.Read();
        }
        }
    }
