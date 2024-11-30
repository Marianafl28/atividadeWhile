using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeWhile
{
    internal class atividade13
    {
        public static void Main(string[] args)
        {
            int numero;
            int pares = 0;
            int impares = 0;

            Console.WriteLine("Digite números inteiros e para sair digite 0");

            while (true)
            {
                Console.Write("Digite um número: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero == 0)
                    {
                        break; 
                    }

                    if (numero % 2 == 0)
                    {
                        pares++;
                    }
                    else
                    {
                        impares++;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                }
            }

            Console.WriteLine("Quantidade de números pares: " + pares);
            Console.WriteLine("Quantidade de números ímpares: " + impares);
        }
    }
}