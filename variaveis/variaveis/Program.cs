using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int segundaGuerraMundial = 1942;
            string cor_favorita = "roxo";
            float velocidade = 294.48f;
            bool segunda_guerra = true;

            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidade);
            Console.WriteLine(segunda_guerra);
            */
            var segundaGuerraMundial = 1942;
            dynamic cor_favorita = "roxo";

            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(cor_favorita);
            
            Console.ReadLine();
        }
    }
}
