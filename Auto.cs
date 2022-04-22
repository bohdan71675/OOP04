using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    class Auto
    {
        private string znacka;
        private double spotrebaNa100;
        private int ujetoCelkem;
        private DateTime rozjezdTime;
        private TimeSpan dobaJizdyCelkem;
        private bool jede;

        public Auto(string znacka, double spotrebaNa100)
        {
            this.znacka = znacka;
            ujetoCelkem = 0;
            dobaJizdyCelkem = new TimeSpan(0);
            this.spotrebaNa100 = spotrebaNa100;
            jede = false;
        }

        public bool GetJede()
        {
            return jede;
        }
        public void Rozjed()
        {
            jede = true;
            rozjezdTime = DateTime.Now;
        }
        public void Zastav(int kilometry)
        {
            jede = false;
            ujetoCelkem += kilometry;
            TimeSpan ujetoZaJednuJizdu = DateTime.Now - rozjezdTime; 
            dobaJizdyCelkem = dobaJizdyCelkem + ujetoZaJednuJizdu; 
        }
        public double CelkovaSpotreba()
        {
            double celkovaSpotreba = (spotrebaNa100 / 100) * ujetoCelkem;
            return celkovaSpotreba;
        }

        public override string ToString()
        {
            string s = "";
            if (GetJede())
            {
                s = "\nAuto jede\nZnačka auta je: " + znacka + "\nSpotřeba auta na 100km je: " + spotrebaNa100 + "\nCelkem ujeto: " + ujetoCelkem + "\nCelková doba jízdy auta: " + dobaJizdyCelkem.TotalMinutes + " Minut\nCelková spotřeba auta je: " + CelkovaSpotreba();
            }
            else
            {
                s = "\nAuto nejede\nZnačka auta je: " + znacka + "\nSpotřeba auta na 100km je: " + spotrebaNa100 + "\nCelkem ujeto: " + ujetoCelkem + "\nCelková doba jízdy auta: " + dobaJizdyCelkem.TotalMinutes + " Minut\nCelková spotřeba auta je: " + CelkovaSpotreba();
            }
            return base.ToString() + s;
        }

    }
}
