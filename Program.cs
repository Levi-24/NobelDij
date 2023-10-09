using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            var nobeldijasok = new List<Tudos>();
            using StreamReader sr = new StreamReader(
                path: @"..\..\..\src\orvosi_nobeldijak.txt",
                Encoding.UTF8
                );
            _ = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                nobeldijasok.Add(new Tudos(sr.ReadLine()));
            }

            Console.WriteLine($"3.Feladat: Díjazottak száma: {nobeldijasok.Count()} fő");
            Console.WriteLine($"4.Feladat: Utolsó év: {nobeldijasok.Max(n => n.Ev)}");

            Console.Write("5.Feladat: Kérem adja meg egy ország kódját: ");
            string orszagKod = Console.ReadLine();

            if (nobeldijasok.Any(n => n.OrszagKod == orszagKod))
            {
                if (nobeldijasok.Count(n => n.OrszagKod == orszagKod) == 1)
                {
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("A megadott országból nem volt díjazott!");
            }
        }
    }
}
