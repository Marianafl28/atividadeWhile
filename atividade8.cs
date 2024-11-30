using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace atividadeWhile
{
    internal class atividade8
    {
        public static void Main(string[] args)
        {
            int secreto = 87; 
            int adivinha = 0; 

            while (secreto != adivinha)
            {
                Console.Write("Digite um número e tente acertar: ");
                string input = Console.ReadLine();

               
                if (int.TryParse(input, out adivinha))
                {
                    if (adivinha == secreto)
                    {
                        Console.WriteLine("Você acertou o número!!");
                    }
                    else
                    {
                        Console.WriteLine("Errou, tente novamente.");
                    }
                }
            }
        }
    }
}
