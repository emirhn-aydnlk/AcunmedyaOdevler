using Odev_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1.Classes
{
    public class Bmw : IGider, IUcar, IYuzer
    {
        public void git(string isim)
        {
            Console.WriteLine(isim + " çok hızlı gider");
        }
        public void uc(string isim)
        {
            Console.WriteLine(isim + " havada uçar");
        }
        public void yuz(string isim)
        {
            Console.WriteLine(isim + " denizde yüzer");
        }
    }
}
