using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace nomes
{


    internal class Program
    {
        static int comLimite(int lim) // ==============Função Arrey com limite===========================
        {

            Console.Write("Quantos usuarios deseja cadastrar? :");
            lim = int.Parse(Console.ReadLine());
            //ira limitar a quantidade de valores a serem inseridos no vetor
            Console.WriteLine("===================================================");
            string[] item = new string[lim];
            //classe ||variavel de referencia|| alocação de espaço na memoria

            string nome;
            int cont2 = 1;

            for (int cont = 0; cont < lim; cont++)
            {
                Console.Write($"Digite o {cont2}ª nome: ");
                nome = Console.ReadLine();
                //solicita um nome

                item[cont] = nome;
                //atribui um valor para o indice conforme a posição do cont
                cont2++;
                Console.Clear();
                Console.WriteLine("===================================================");
            }

            for (int cont1 = 0; cont1 < lim; cont1++)
            {
                Console.WriteLine($"O nome {item[cont1]} esta cadastrado no indice: {cont1}"); ;
            }

            Console.Write("\nDigite o indice que deseja verificar: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"O indice corresponde ao nome: {item[num1]}");
            Console.ReadLine();
            return lim;
        }

        static int semLimite(int contt)// ==============Função Arrey sem limite===========================
        {
            List<string> nome = new List<string>();
            //apartir daqui é possivel criar um parametro para lista. e isto garante ilimitações
            string ind, resp1 = "", resp = "";
            int cont1 = 1, conta = 0;
            // for (int index = 0; index < 5; index++)

            do
            {
                Console.Write($"Digite o {cont1}ª nome: ");
                ind = Console.ReadLine();
                nome.Add(ind);
                Console.Write("Deseja continuar? [s/n]: ");
                resp = Console.ReadLine();
                conta++;
                cont1++;
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
            } while (resp == "s");
            //condição desejada de repetiçoes

            Console.WriteLine($"Foram cadastrados {cont1} nomes.");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Deseja listar o(s) nome(s)? [s/n]");
            resp1 = Console.ReadLine();
            Console.WriteLine("---------------------------------------------");
            if (resp1 == "s")
            {
                string[] arr_sample = nome.ToArray();
                //criação do arrey para receber a list

                for (int index = 0; index < conta; index++)
                {
                    System.Console.WriteLine(arr_sample[index]);
                    Console.WriteLine("---------------------------------------------");
                }
                //imprime os valores 
            }
            else Console.WriteLine("Obrigado");

            Console.ReadLine();
            return contt;
        }


        static void Main(string[] args)
        {
            int esco;
            do
            {
                Console.WriteLine("|============-CADASTRO DE USUARIOS-=============|");
                Console.WriteLine("|----------------Seja bem vindo!----------------|");
                Console.WriteLine("|===============================================|");
                Console.Write("Como deseja realizar o cadastro? \n1 - De forma limitada \n2 - De forma ilimitada \n3 - Sair \n: ");
                esco = int.Parse(Console.ReadLine());
                Console.WriteLine("|-----------------------------------------------|");

                switch (esco)
                {
                    case 1:
                        comLimite(1);
                        break;
                    case 2:
                        semLimite(1);
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção ivalida");
                        break;
                 
                }
                Console.ReadLine();
                Console.Clear();

            } while (esco > 3);
        }
    }
}
