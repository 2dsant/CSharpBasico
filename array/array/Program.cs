using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = new string[5] {
                "sea of Thrives",
                "FIFA",
                "Minecraft",
                "League of Legends",
                "Half Life"
            };

            Console.WriteLine(produtos[4]);

            Console.ReadLine();
        }
    }
}
