using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_CD_KEY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string klucz = "";
            int dlugoscKlucza = int.Parse(txtDlugosc.Text);
            int liczbaZnakow = 0;
                                 
            Random liczbaLosowa = new Random();
            while (liczbaZnakow < dlugoscKlucza)
            {
                int cyfra = liczbaLosowa.Next(0, 9);
                klucz += cyfra.ToString();
                liczbaZnakow++;
                if (liczbaZnakow % 5 == 0 && liczbaZnakow < dlugoscKlucza)
                
                {
                    klucz += "-";
                }
            }
            txtKlucz.Text = klucz;
        }
    }
}
