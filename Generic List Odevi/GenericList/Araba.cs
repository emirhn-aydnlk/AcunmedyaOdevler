using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class Araba
    {
        public string marka { get; set; } //Arabanın markası
        public string model { get; set; } //Arabanın modeli
        public double benzinHarcamasi { get; set; } //100km başına tükettiği yakıt miktarı
        public double toplamMesafe { get; set; } //Arabanın toplamda kaç km yol gittiğini tutar

        public double ToplamYakitTuketimi()
        {
            return (toplamMesafe / 100) * benzinHarcamasi;
        }
    }
}
