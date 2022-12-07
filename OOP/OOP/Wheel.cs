using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Wheel
    {
        private int velikost;
        public Wheel()
        {
            velikost = 15;
        }
        public Wheel(int velikost)
        {
            this.velikost = velikost;
        }

        public override string ToString()
        {
            return velikost.ToString();
        }
    }
}
