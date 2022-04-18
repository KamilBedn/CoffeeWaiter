using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kawiarnia
{
    abstract class Ciasto : IProdukt
    {
        public const int MinPorcja = 100;
        protected int waga;
        protected bool juzZamowione = false;

        public float DajCene()
        {
            return waga / 100f * 6;
        }
        public virtual string Zamow()
        {
            string tekst = $"Zamowiles ciasto o wadze {Waga}";
            juzZamowione = true;
            return tekst;
        }
        public int Waga
        {
            get
            {
                return waga;
            }
            set
            {
                if (!juzZamowione && value >= MinPorcja)
                    waga = value;
            }
        }
        public Ciasto()
        {
            waga =  MinPorcja;
        }
        public Ciasto(int waga) : this()
        {
            this.Waga = waga;
        }
    }
}
