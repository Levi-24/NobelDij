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
        public string SzuletesHalalozas { get; set; }
        public string OrszagKod { get; set; }

        public Tudos(string sor)
        {
            var darab = sor.Split(';');
            this.Ev = int.Parse(darab[0]);
            this.Nev = darab[1];
            this.SzuletesHalalozas = darab[2];
            this.OrszagKod = darab[3];
        }
    }
}
