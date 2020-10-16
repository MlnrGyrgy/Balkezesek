using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Balkezesek
{
    class Program
    {
        static List<BalkezesDobo> balos = new List<BalkezesDobo>();
        static void Beolvasas()
        {
            StreamReader file = new StreamReader("balkezesek.csv");
            file.ReadLine();
            while (!file.EndOfStream)
            {
                string[] egy = file.ReadLine().Split(';');
                balos.Add(new BalkezesDobo(egy[0], egy[1], egy[2], int.Parse(egy[3]), int.Parse(egy[4])));
            }
            file.Close();
        }
        static void Megszamolas()
        {
            Console.WriteLine("Az adatok száma: {0}", balos.Count());
        }
        static void OktMagassag()
        {
            foreach (var i in balos)
            {
                if (i.utolso.Contains("1999-10-"))
                {
                    Console.WriteLine($"{i.nev}, {Math.Round(i.magassag * 2.54, 1):N1}");
                }
            }
        }
        static void BekeresEsMunka()
        {
            int evszam = 0;
            bool hibas = false;
            do
            {
                Console.Write("Kérek egy évszámot 1990 és 1999 között!: ");
                evszam = int.Parse(Console.ReadLine());
                if (evszam < 1990 || evszam > 1999)
                {
                    hibas = true;
                    Console.WriteLine("Hibás adat!");
                }
            } while (hibas);
            var eves = from b in balos where Convert.ToInt32(b.elso.Substring(0,4)) <= evszam && Convert.ToInt32(b.utolso.Substring(0, 4))>=evszam select b;
            var evesLista = eves.ToList();
            double szum = 0;
            foreach (var e in evesLista)
            {
                szum+= e.suly;
            }
            double atlag = Math.Round(szum / evesLista.Count(),2);
            Console.WriteLine($"{atlag} font");
        }
        static void Main(string[] args)
        {
            Beolvasas();
            Megszamolas();
            OktMagassag();
            BekeresEsMunka();
            Console.ReadKey();
        }
    }
}
