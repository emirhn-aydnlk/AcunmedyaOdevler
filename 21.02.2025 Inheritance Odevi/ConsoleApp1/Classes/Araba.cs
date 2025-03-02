using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Araba
    {
        public string vites;
        public string marka;
        public void yaz(string vites, string marka)
        {
            Console.WriteLine(marka + " " + vites + " viteslidir");
        }
    }
}
