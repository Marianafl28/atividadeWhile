using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeWhile
{
    internal class atividade9
    {
        public static void Main(string[] args)
        {
            string vogal;

            while (true)
            {
                Console.WriteLine("Digite uma palavra com vogais, caso queira sair digite a palavra fim");
                vogal = Console.ReadLine();

                if (vogal == "fim")
                {
                    break;
                }

                int quantidade = 0;

                foreach (char letra in vogal)
                {

                    if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                    {
                        quantidade++;
                    }
                }
                Console.WriteLine("A quantidade de vogais é de " + quantidade);
            }
        }
    }
}
