using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Osoba
    {
        string jmeno;
        DateTime narozen;

        public Osoba(string jmeno, string narozen)
        {
            this.jmeno = jmeno;
            this.narozen = DateTime.Parse(narozen);
        }
        public Osoba(string jmeno, DateTime narozen)
        {
            this.jmeno = jmeno;
            this.narozen = narozen;
        }

        public void NastavJmeno(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public string VypisJmeno()
        {
            return jmeno;
        }
        public int Vek()
        {
            TimeSpan result = DateTime.Now - narozen;
            return (int)(result.Days / 365.25);
        }
        public bool Plnolety()
        {
            if (Vek() >= 18)
                return true;
            return false;
        }
        public string Starsi(Osoba druha)
        {
            if (druha.Vek() > this.Vek())
                return "Starší:" + druha.VypisJmeno();
            return "Starší:" + this.VypisJmeno();
        }
        public override string ToString()
        {
            return this.VypisJmeno()+" má "+this.Vek()+" a "+ (this.Plnolety() ? "je" : "není") + " plnoletý.";
        }
    }
}
