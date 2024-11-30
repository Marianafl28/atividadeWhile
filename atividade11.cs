using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeWhile
{
    internal class atividade11
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero != 0)
            {
                int contador = 0;
                int quantidade = Math.Abs(numero);

                while (quantidade > 0)
                {
                    quantidade /= 10;
                    contador++;
                }
                Console.Write("O numero " +numero + " possui " +contador + " de digitos");
            }
            else
            {
                Console.WriteLine("Não é um numero valido");
            }
         }
    }
}
