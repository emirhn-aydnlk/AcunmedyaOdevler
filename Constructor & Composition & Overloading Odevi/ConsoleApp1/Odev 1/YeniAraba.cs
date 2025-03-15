using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Odev_1
{
    public class YeniAraba
    {
        public Araba araba;
        public string marka;
        public string model;

        public YeniAraba(Araba araba, string marka, string model)
        {
            this.araba = araba;
            this.marka = marka;
            this.model = model;
        }

        public void arabaBilgileri()
        {
            Console.WriteLine("Arabanın markası: " + marka
                + ", modeli: " + model
                + ", kapi sayisi: " + araba.kapi.kapiSayisi
                + ", pencere sayisi: " + araba.pencere.pencereSayisi
                + ", kasası: " + araba.kasa.kasa
                + ", fiyatı: " + araba.fiyat.fiyat + " TL'dir.");
        }
    }
}
