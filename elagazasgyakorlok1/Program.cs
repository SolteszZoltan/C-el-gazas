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

            Console.WriteLine("Add meg egy hónapnak a sorszámát");
            int honap = int.Parse(Console.ReadLine());
            if (honap == 1 || honap == 2 || honap == 12)
                Console.WriteLine("A hónap a Tél-hez tartozik");
            else if (honap == 3 || honap == 4 || honap == 5)
                Console.WriteLine("A hónap a Tavasz-hoz tartozik");
            else if (honap == 6 || honap == 7 || honap == 8)
                Console.WriteLine("A hónap a Nyár-hoz tartozik");
            else if (honap > 12)
                Console.WriteLine("Nincs ilyen hónap");
            else
                Console.WriteLine("A hónap az Ősz-höz tartozik");

        }
    }
}

