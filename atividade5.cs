using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeWhile
{
    internal class atividade5
    {
        public static void Main(string[] args)
        {
            int valor;

            do

            {
                Console.WriteLine("Digite um numero");
                valor = int.Parse(Console.ReadLine());
            }

            while (valor % 2 != 0);

                Console.WriteLine("Numero par digitado");
            }
    }
}


