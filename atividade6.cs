using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeWhile
{
    internal class atividade6
    {
        public static void Main(string[] args)
        {
            string escolha = "";

            while (escolha != "sair" && escolha != "Sair")
            {
                Console.WriteLine("Digite um operador ou 'sair' para sair");
                escolha = Console.ReadLine();

                if (escolha.ToLower() == "sair")
                {
                    break; 
                }

                if (escolha != "+" && escolha != "-" && escolha != "*" && escolha != "/")
                {
                    Console.WriteLine("Operação inválida. Por favor, digite um valido");
                    continue; 
                }

                double numero1;
                double numero2;

                
                Console.WriteLine("Digite um número:");
                string input1 = Console.ReadLine();
                if (!double.TryParse(input1, out numero1))
                {
                    Console.WriteLine("Digite um número válido.");
                    continue; 
                }

                Console.WriteLine("Digite outro número:");
                string input2 = Console.ReadLine();
                if (!double.TryParse(input2, out numero2))
                {
                    Console.WriteLine("Digite um número válido.");
                    continue; 
                }

                if (escolha == "+")
                {
                    Console.WriteLine("Resultado: " + (numero1 + numero2));
                }
                else if (escolha == "-")
                {
                    Console.WriteLine("Resultado: " + (numero1 - numero2));
                }
                else if (escolha == "*")
                {
                    Console.WriteLine("Resultado: " + (numero1 * numero2));
                }
                else if (escolha == "/")
                {
                    if (numero2 != 0)
                    {
                        Console.WriteLine("Resultado: " + (numero1 / numero2));
                    }
                    else
                    {
                        Console.WriteLine(" Divisão por zero não é permitida.");
                    }
                }
            }

            Console.WriteLine("Tchau calculadora.");
        }
    }
}