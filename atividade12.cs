using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeWhile
{
    internal class atividade12
    {
        public static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.WriteLine("Digite um numero entre 1 e 100");
            }
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 100);
            Console.WriteLine("O numero é " + numero);
        }
    }
}
