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
        private DateTime dobaJizdCelkem;
        private bool jede;
        public bool Jede { get=>jede; }

        public Auto(string znacka, float spotrebaNa100, int ujetoCelkem, DateTime dobaJizdCelkem)
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
            jede = true;
            casRozjezdu = DateTime.Now;
        }

        public void Zastav(int ujeteKm)
        {
            jede = false;
            ujetoCelkem += ujeteKm;
            TimeSpan ts = DateTime.Now - casRozjezdu;
            dobaJizdCelkem.AddSeconds(ts.TotalSeconds);
        }
    }
}
