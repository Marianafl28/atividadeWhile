using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace atividadeWhile
{
    internal class atividade04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para a tabuada");
            int tabuada = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("A tabuada do numero " + tabuada);

            int inicio = 1;
            while (inicio <= 10)
            {
                int resultado = tabuada * inicio;
                Console.WriteLine(tabuada + " x " + inicio + " = " + resultado);
                inicio++;
            }
        }
    }
}
