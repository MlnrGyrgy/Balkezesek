using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    class BalkezesDobo
    {
        public string nev { get; private set; }
        public string elso { get; private set; }
        public string utolso { get; private set; }
        public int suly { get; private set; }
        public int magassag { get; private set; }

        public BalkezesDobo(string nev, string elso, string utolso, int suly, int magassag)
        {
            this.nev = nev;
            this.elso = elso;
            this.utolso = utolso;
            this.suly = suly;
            this.magassag = magassag;
        }
    }
}
