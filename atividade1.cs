using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeWhile
{
    internal class atividade1
    {
       public static void Main(string[] args)
        {
            int contadora = 0;
            while (contadora <= 10)
            {
                Console.WriteLine(contadora);
                contadora++;
            }
            Console.WriteLine("Fim da contagem de 0 a 10");
        }
    }
}




