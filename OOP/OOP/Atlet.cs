using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Atlet
    {
        private string jmeno;
        public string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                if (value.First() > 'a' && value.First() < 'z')
                {
                    StringBuilder sb = new StringBuilder(value);
                    sb[0] = (char)(sb[0] - 32);
                    jmeno = sb.ToString();
                }
                else
                    jmeno = value;
            }
        }
        private int unava = 0;

        public Atlet(string jmeno)
        {
            Jmeno = jmeno;
        }

        public void Behej(int pocetKm)
        {
            for(int i = 0;i<pocetKm;i++)
            {
                if(unava>=200)
                {
                    MessageBox.Show("běžec je moc unavený!!");
                    break;
                }
                unava += 10;
            }
        }

        public void Spi(int pocetHodin)
        {
            unava -= pocetHodin * 100;
            if (unava < 0)
                unava = 0;
        }

        public int ZjistitUnavu()
        {
            return unava;
        }
    }
}
