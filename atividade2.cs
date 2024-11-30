using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeWhile
{
    internal class atividade2
    {
        public static void Main(string[] args)
        {
            int soma = 0;
            int numero;
            do
            {
                Console.WriteLine("Digite um numero");
                    numero =  Convert.ToInt16(Console.ReadLine());
                soma += numero;
            }
            while (numero != 0);

            Console.WriteLine("A soma dos numeros é de " + soma);
        }
    }
}
        
    