using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Auto auto;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                auto = new Auto(textBox1.Text, float.Parse(textBox2.Text), int.Parse(textBox3.Text), TimeSpan.Parse(textBox4.Text));
                AktualizujData();
                groupBox2.Enabled = true;

            } catch
            {
                MessageBox.Show("Špatný formát vstupu!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            auto.Zastav((new Random()).Next(1,2000));
            AktualizujData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto.Rozjed();
            AktualizujData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(auto.ToString(),"Auto",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        void AktualizujData()
        {
            label6.Text = "Jede auto: " + auto.Jede;
            label7.Text = "Najeté km: " + auto.VratUjeteKm();
            label8.Text = "Spotřeba: " + auto.CelkovaSpotreba();
        }
    }
}
