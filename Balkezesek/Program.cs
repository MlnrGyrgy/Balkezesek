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
                balos.Add(new BalkezesDobo(egy[0],egy[1],egy[2], int.Parse(egy[3]), int.Parse(egy[4])));
            }
            file.Close();
        }
        static void Main(string[] args)
        {
            Beolvasas();
           
            Console.ReadKey();
        }
    }
}
