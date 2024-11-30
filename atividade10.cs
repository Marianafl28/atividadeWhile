using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeWhile
{
    internal class atividade10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 2)
            {
                bool primo = true;
                int divisor = 2;

                while (divisor <= Math.Sqrt(numero))
                { 
                    if (numero % divisor == 0)
                    {
                        primo = false;
                        break;
                    }
                    divisor++;
                }
                if (primo)
                {
                    Console.WriteLine("O numero " + numero + " é primo" );
                }
                else
                {
                    Console.WriteLine("O numero " + numero + " não é primo");
                }
            }
        }
    }
}
