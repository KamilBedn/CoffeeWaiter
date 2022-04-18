using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kawiarnia
{
    class Sernik : Ciasto
    {
        public override string Zamow()
        {
            base.Zamow();
            string tekst = $"- {waga}g Serinka";
            return tekst;
        }
        public Sernik() : base() { }
        public Sernik(int waga) : base(waga) { }
    }
}
