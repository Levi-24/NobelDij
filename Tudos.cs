using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Tudos
    {
        public int Ev { get; set; }
        public string Nev { get; set; }
        public string SzuletesHalalozasStr { get; set; }
        public (int Szuletes, int? Halal) SzH { get; set; }
        public string OrszagKod { get; set; }

        public Tudos(string sor)
        {
            var darab = sor.Split(';');
            this.Ev = int.Parse(darab[0]);
            this.Nev = darab[1];
            this.SzuletesHalalozasStr = darab[2];

            var szhv = darab[2].Split('-');
            int? h = szhv[1].Length == 0 ? null : int.Parse(szhv[1]);
            SzH = (int.Parse(szhv[0]), h);

            this.OrszagKod = darab[3];
        }
    }
}
