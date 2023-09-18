using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ZsirSzenhidrat
{
    class Program
    {
        static void Main(string[] args)
        {
            var kenyerek = new List<Kenyer>();
            using var sr = new StreamReader(
                path: "../../../src/Adat.txt",
                Encoding.UTF8);

            while (!sr.EndOfStream) kenyerek.Add(new Kenyer(sr.ReadLine()));

            Console.WriteLine("1.Feladat");
            foreach (var kenyer in kenyerek) Console.WriteLine($"{kenyer.Nev} {kenyer.Zsir} {kenyer.Zsenhidrat}");

            Console.WriteLine("2.Feladat");
            var minZsir = kenyerek.Min(k => k.Zsir);
            foreach (var k in kenyerek) if (k.Zsir == minZsir) Console.WriteLine(k.Nev);
        }
    }
}
