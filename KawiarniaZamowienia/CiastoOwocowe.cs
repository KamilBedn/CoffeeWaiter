using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kawiarnia
{
    class CiastoOwocowe : Ciasto
    {
        public enum RodzajOwoca { Jablko, Jagody, Maliny};
        private RodzajOwoca Owoce;
        public CiastoOwocowe() : base()
        {
            Owoce = RodzajOwoca.Jablko;
        }
        public CiastoOwocowe(int waga) : base(waga)
        {
            Owoce = RodzajOwoca.Jablko;
        }
        public CiastoOwocowe(int waga, RodzajOwoca owoc) : this(waga)
        {
            Waga = waga;
            Owoce = owoc;
        }
        public override string Zamow()
        {
            base.Zamow();
            string tekst = " ";
            switch (Owoce)
            {
                case RodzajOwoca.Jablko:
                    tekst += $"- {waga}g ciasta z jabłkami";
                    break;
                case RodzajOwoca.Jagody:
                    tekst += $"- {waga}g ciasta z jagodami";
                    break;
                case RodzajOwoca.Maliny:
                    tekst += $"- {waga}g ciasta z malinami.";
                    break;
            }
            return tekst;   
        }
    }
}
