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

            Console.WriteLine("Add meg a korod: ");
            int kor = int.Parse(Console.ReadLine());
            if (kor < 18)
                Console.WriteLine("Nem szavazhat");
            else 
                Console.WriteLine("Szavazhat");

            Console.WriteLine("Add meg az értékelést (1-5): ");
            int jegy = int.Parse(Console.ReadLine());
            if (jegy == 1 || jegy == 2)
                Console.WriteLine("Elégtelen");
            else if (jegy == 3)
                Console.WriteLine("Elégséges");
            else if (jegy == 4)
                Console.WriteLine("jó");
            else
                Console.WriteLine("jeles");

            int kitalal = 5;
            Console.WriteLine("Találd ki a számot amire gondoltam: ");
            int szamkitalalos = int.Parse(Console.ReadLine());
            if (szamkitalalos == kitalal)
                Console.WriteLine("Eltaláltad");
            else if (szamkitalalos > kitalal)
                Console.WriteLine("Nem talált, kisebb szám");
            else
                Console.WriteLine("Nem talált, nagyobb szám");
                
        Console.WriteLine("Adj meg egy számot: ");
            int joszam = int.Parse(Console.ReadLine());
            if (szam > 0 && szam % 2 == 0)
                Console.WriteLine("A szám pozitív és páros");
            else
                Console.WriteLine("A szám nem pozítív és páros");

            Console.WriteLine("Adj meg egy karaktert: ");
            char character = Console.ReadKey().KeyChar;

            if (char.IsDigit(character))
                Console.WriteLine("Ez egy szám");
            else if (char.IsLetter(character))
                Console.WriteLine("Ez egy betű");
            else 
                Console.WriteLine("Se nem szám, se nem betű");

            string jelszo = "titok123";
            Console.WriteLine("Add meg a jelszót");
            string jelszokitalalas = Console.ReadLine();
            if (jelszokitalalas == jelszo)
                Console.WriteLine("Helyes jelszó!");
            else Console.WriteLine("Helytelen jelszó");

        }
    }
}

