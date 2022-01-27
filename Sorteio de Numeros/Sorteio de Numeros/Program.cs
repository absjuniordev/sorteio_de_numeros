using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteio_de_Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp = "";
            do
            {
                Console.WriteLine("==== Jogo de dados =======");
                Random dice = new Random();
                //Classe (Rondom) variavel referencia (dice) reserva de espaço nameria para o tipo da classe (new)
                int roll1 = dice.Next(1, 7);
                //(roll1) receberá os valores de metodo (Next) do (dice) que recebe os parametro (())  
                int roll2 = dice.Next(1, 7);
                int roll3 = dice.Next(1, 7);

                int total = roll1 + roll2 + roll3;

                Console.WriteLine($"Numeros: {roll1} + {roll2} + {roll3} = {total}");

                if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
                {
                    if ((roll1 == roll2) && (roll2 == roll3))
                    {
                        Console.WriteLine("Você rolou triplos! +6 bonus to total!");
                        total += 6;
                    }
                    else
                    {
                        Console.WriteLine("Você roliu duplos!  +2 bonus to total!");
                        total += 2;
                    }
                }

                if (total >= 16)
                {
                    Console.WriteLine("Você ganhou um carro novo!");
                }
                else if (total >= 10)
                {
                    Console.WriteLine("Você ganhou um laptop!");
                }
                else if (total == 7)
                {
                    Console.WriteLine("Você ganhou uma viagem para dois!");
                }
                else
                {
                    Console.WriteLine("Você ganhou uma camiseta !");
                }
                Console.WriteLine("======== ========= =======");
                
                Console.WriteLine("Deseja realizar outro sorteio? [s/n]");
                resp = Console.ReadLine();
                Console.Clear();
            } while (resp == "s");
                          
        }
    }
}
