using Odev_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1.Classes
{
    public class Porsche : IUcar
    {
        public void uc(string isim)
        {
            Console.WriteLine(isim + " havada uçar");
        }
    }
}
