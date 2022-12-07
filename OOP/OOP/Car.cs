using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Car
    {
        public string model;
        private string znacka;
        Wheel kola;
        public Car()
        {
            model = " - ";
            znacka = " - ";
            this.kola = new Wheel();
        }
        public Car(string znacka)
        {
            model = " - ";
            this.znacka = znacka;
            this.kola = new Wheel();
        }
        public Car(string znacka, string model)
        {
            this.znacka = znacka;
            this.model = model;
            this.kola = new Wheel();
        }

        public void turnRight()
        {
            MessageBox.Show("Doprava!");
        }
        public void turnLeft()
        {
            MessageBox.Show("Doleva!");
        }
        public void driveStraight()
        {
            MessageBox.Show("Rovně!");
        }

        public override string ToString()
        {
            return model+" "+znacka;
        }
    }
}
