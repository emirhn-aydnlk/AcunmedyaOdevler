using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Odev_1
{
    public class Araba
    {
        public Fiyat fiyat;
        public Kapi kapi;
        public Kasa kasa;
        public Pencere pencere;

        public Araba(Fiyat fiyat, Kapi kapi, Kasa kasa, Pencere pencere)
        {
            this.fiyat = fiyat;
            this.kapi = kapi;
            this.kasa = kasa;
            this.pencere = pencere;
        }
    }
}
