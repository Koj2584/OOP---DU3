using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Auto
    {
        private string znacka;
        private float spotrebaNa100;
        private int ujetoCelkem;
        private DateTime casRozjezdu;
        private TimeSpan dobaJizdCelkem;
        private bool jede;
        public bool Jede { get=>jede; }

        public Auto(string znacka, float spotrebaNa100, int ujetoCelkem, TimeSpan dobaJizdCelkem)
        {
            this.znacka = znacka;
            this.spotrebaNa100 = spotrebaNa100;
            this.ujetoCelkem = ujetoCelkem;
            this.dobaJizdCelkem = dobaJizdCelkem;
            jede = false;
        }

        public int VratUjeteKm()
        {
            return ujetoCelkem;
        }

        public void Rozjed()
        {
            if (!jede)
            {
                jede = true;
                casRozjezdu = DateTime.Now;
            }
        }

        public void Zastav(int ujeteKm)
        {
            if (jede)
            {
                jede = false;
                ujetoCelkem += ujeteKm;
                TimeSpan ts = DateTime.Now - casRozjezdu;
                dobaJizdCelkem = dobaJizdCelkem + ts;
            }
        }

        public float CelkovaSpotreba()
        {
            return ujetoCelkem / 100 * spotrebaNa100;
        }

        public override string ToString()
        {
            return "Značka: "+znacka+"\nSpotřeba na 100km: "+spotrebaNa100+"\nCelkem ujeto: "+ujetoCelkem+"\nČas posledního rozjezdu: "+
                casRozjezdu.ToString()+"\nCelková doba jízd: "+Math.Round(dobaJizdCelkem.TotalDays,2)+" dní\nJe auto na cestě: "+jede;
        }
    }
}
