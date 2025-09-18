using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elagazasgyakorlok1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam % 2 == 0)
                Console.WriteLine("páros");
            else
                Console.WriteLine("páratlan");
            if (szam > 0)
                Console.WriteLine("Pozitív");
            else if (szam < 0)
                Console.WriteLine("Negatív");
            else
                Console.WriteLine("Nulla");

        }
    }
}

