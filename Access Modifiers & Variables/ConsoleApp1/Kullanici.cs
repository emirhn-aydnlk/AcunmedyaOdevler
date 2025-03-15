using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kullanici
    {
        private string ad { get; set; }
        private string soyad { get; set; }
        private int yas { get; set; }
        public string email;

        public string Ad
        {
            get { return ad; } 
            set { ad = value; } 
        }

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public int Yas
        {
            get { return yas; }
            set { yas = value; }
        }

        public void BilgileriGoster()
        {
            Ad = "Ahmet";
            Soyad = "Yılmaz";
            Yas = 25;

            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Soyad: {Soyad}");
            Console.WriteLine($"Yaş: {Yas}");
        }
    }
}
