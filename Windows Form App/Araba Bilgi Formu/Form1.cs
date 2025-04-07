using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_Bilgi_Formu
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string markasi = marka.Text;
            string modeli = model.Text;
            string rengi = renk.Text;
            int kapi = Convert.ToInt32(kapiSayisi.Text);
            int pencere = Convert.ToInt32(pencereSayisi.Text);
            double tuketim = Convert.ToDouble(yakitTuketimi.Text);
            MessageBox.Show("Marka: " + markasi + "\n" +
                            "Model: " + modeli + "\n" +
                            "Renk: " + rengi + "\n" +
                            "Kapı Sayısı: " + kapi + "\n" +
                            "Pencere Sayisi: " + pencere + "\n" +
                            "Yakıt Tüketimi: " + tuketim + "L/100km", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
