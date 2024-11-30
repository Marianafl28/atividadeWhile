using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeWhile
{
    internal class atividade14
    {
        public static void Main(string[] args)
        {
            int numero;
            int somaPares = 0;

            Console.WriteLine("Digite números inteiros. Para parar, digite 0.");
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
                        somaPares += numero; 
                    }
                }
            }

            Console.WriteLine("A soma dos números pares digitados é:" + somaPares);
        }
    }
}

