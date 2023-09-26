using System;
using System.IO;

namespace CBRADIO
{
    class Program
    {
        static void Main(string[] args)
        {
            var hivasok = new List<Hivas>()
            using var sr = new StreamReader(
                path: @"..\..\..\src\cb.txt");
            _ = sr.ReadLine();
            while (!sr.EndOfStream) hivasok.Add(new(sr.ReadLine()));
            {
                Console.WriteLine($"{hivasok.count}");
                Console.WriteLine();
                bool f3 = hivasok.Any(h => h.adatsb == 4);
                Console.WriteLine($"{(f3 ? "volt":"nem volt")} 4adat werwqe");
                Console.WriteLine("kerek egy nevet");
                string knev = Console.ReadLine();
                int f5 = hivasok
                    .Where(h => h.Nev.Tolower() == knev.ToLower())
                    .Sum(h => h.adatcb);
                if (f5 != 0) Console.WriteLine($"\t {h.Nev }{f5}hasznalta ");
                else Console.WriteLine("nincs ilyen nevu sofor");
                {
                   
                }
                {

                }
                using var sw = new StreamReader(
                    path: @"..\..\..\src\asd.txt")
                    append:false
                    enc
            }
        }
    }
}
