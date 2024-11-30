using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeWhile
{
    internal class atividade15
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número: ");

            if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
            {
                int potencia = 1;
                int resultado = numero;

                Console.WriteLine("Sequência de multiplicação de " + numero + " por potências de 2:");

                while (resultado <= 1000)
                {
                    Console.WriteLine("O numero " + numero + " x " + potencia + " = " + resultado);
                    potencia *= 2;
                    resultado = numero * potencia;
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro positivo válido.");
            }
        }
    }
}