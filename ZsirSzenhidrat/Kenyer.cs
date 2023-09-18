using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZsirSzenhidrat
{
    class Kenyer
    {
        public string Nev { get; set; }
        public double Zsir { get; set; }
        public double Zsenhidrat { get; set; }

        public Kenyer (string BeolvasottSor)
        {
            var darabok = BeolvasottSor.Split(';');
            this.Nev = darabok[0];
            this.Zsir = double.Parse(darabok[1]);
            this.Zsenhidrat = double.Parse(darabok[2]);
        }
    }
}
