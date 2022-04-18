using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kawiarnia;

namespace KawiarniaZamowienia
{ 
    public partial class Form1 : Form
    {
        List<IProdukt> produkt = new List<IProdukt>();
        public float Suma;
        public Form1()
        { 
            InitializeComponent();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OProgramie okno = new OProgramie();
            okno.Show();
        }

        private void Podsumowanie_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zaplata_TextChanged(object sender, EventArgs e)
        {
            foreach(IProdukt zaplata in produkt)
            {
                Suma += zaplata.DajCene();
                Zaplata.AppendText(Suma.ToString());
            }
        }

        private void WagaCiast_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Zaplac_Click(object sender, EventArgs e)
        {
            Zaplata.Clear();
            Podsumowanie.Clear();
            produkt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int waga = int.Parse(WagaCiast.Text);
            if (waga < 100)
                waga = 100;
            if (CiastoZMalinami.Checked)
            {
                produkt.Add(new CiastoOwocowe(waga, CiastoOwocowe.RodzajOwoca.Maliny));
                foreach (IProdukt podsumowania in produkt)
                {
                    Podsumowanie.AppendText($"{podsumowania.Zamow()},\n");
                    Suma += podsumowania.DajCene();
                }
            }
            else if (CiastoZJablkami.Checked)
            {
                produkt.Add(new CiastoOwocowe(waga, CiastoOwocowe.RodzajOwoca.Jablko));
                foreach (IProdukt podsumowania in produkt)
                {
                    Podsumowanie.AppendText($"{podsumowania.Zamow()},\n");
                    Suma += podsumowania.DajCene();
                }
            }
            else if (CiastoZJagodami.Checked)
            {
                produkt.Add(new CiastoOwocowe(waga, CiastoOwocowe.RodzajOwoca.Jagody));
                foreach (IProdukt podsumowania in produkt)
                {
                    Podsumowanie.AppendText($"{podsumowania.Zamow()},\n");
                    Suma += podsumowania.DajCene();
                }
            }
            else
            {
                produkt.Add(new Sernik(waga));
                foreach (IProdukt podsumowania in produkt)
                {
                    Podsumowanie.AppendText($"{podsumowania.Zamow()},\n");
                    Suma += podsumowania.DajCene();
                }
            }
                WagaCiast.Clear();
        }

        private void ZamówienieKawy_Click(object sender, EventArgs e)
        {
            if (KawaCzarna.Checked)
            {
                produkt.Add(new Kawa());
                foreach (IProdukt podsumowania in produkt)
                {
                    Podsumowanie.AppendText($"{podsumowania.Zamow()},\n");
                    Suma += podsumowania.DajCene();
                }
            }
            else if(KawaBiala.Checked)
            {
                produkt.Add(new Kawa(true));
                foreach (IProdukt podsumowania in produkt)
                {
                    Podsumowanie.AppendText($"{podsumowania.Zamow()},\n");
                    Suma += podsumowania.DajCene();
                }
            }
        }
    }
}
