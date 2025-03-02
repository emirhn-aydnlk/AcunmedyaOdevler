using Odev_3___4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3___4.Abstracts
{
    class Porsche : Araba, IOzellik
    {
        public override double surusSaati()
        {
            return 1.0;
        }

        public double yakitTuketimi()
        {
            return 60.0;
        }
    }
}
