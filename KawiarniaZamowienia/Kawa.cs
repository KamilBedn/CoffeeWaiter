using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kawiarnia
{
    class Kawa : IProdukt
    {
        private static int IleWydanoKaw = 0;
        public bool ZMlekiem;
        public Kawa(bool ZMlekiem)
        {
            this.ZMlekiem = ZMlekiem;
            IleWydanoKaw++;
        }
        public Kawa()
        {
            ZMlekiem = false;
            IleWydanoKaw++;
        }
        public float DajCene()
        {
            float cena = 5;
            if (ZMlekiem) cena += 2;
            return cena;
        }
        public string Zamow()
        {
            string tekst = $"- Kawa Czarna";
            if (ZMlekiem)
            {
                tekst = $"- Kawa Biała";
                return tekst;
            }
            else
                return tekst;
            
        }
        public static void Raport()
        {
            Console.WriteLine($"Wydano kaw: {IleWydanoKaw}");
        }
    }
}
