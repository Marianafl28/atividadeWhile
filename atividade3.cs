using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeWhile
{
    internal class atividade3
    {
        public static void Main(string[] args)
        {
            int contadora = 10;
            while (contadora >= 0)
            {
                Console.WriteLine(contadora);
                contadora--;
            }
            Console.WriteLine("Fim da contagem de 10 a 0");
        }
    }
}
