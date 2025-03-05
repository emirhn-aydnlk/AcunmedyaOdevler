using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03._2025_31._03._2025_Simple_Calculator
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("İlk sayıyı giriniz: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("(1=Toplama, 2=Çıkarma, 3=Çarpma, 4=Bölme) İşlem numarası giriniz: ");
            int islem = Convert.ToInt32(Console.ReadLine());

            if (islem == 1)
            {
                Toplama(a, b);
            }
            else if (islem == 2)
            {
                Cikarma(a, b);
            }
            else if (islem == 3)
            {
                Carpma(a, b);
            }
            else if (islem == 4)
            {
                Bolme(a, b);
            }
            else
            {
                Console.WriteLine("Geçersiz işlem numarası!");
            }
        }
        static void Toplama(double a, double b)
        {
            Console.WriteLine("Toplama işlemi yapılıyor...");
            double sonuc = a + b;
            Console.Write("İşlem sonucu: " + sonuc);
        }
        static void Cikarma(double a, double b)
        {
            Console.WriteLine("Çıkarma işlemi yapılıyor...");
            double sonuc = a - b;
            Console.Write("İşlem sonucu: " + sonuc);
        }
        static void Carpma(double a, double b)
        {
            Console.WriteLine("Çarpma işlemi yapılıyor...");
            double sonuc = a * b;
            Console.Write("İşlem sonucu: " + sonuc);
        }
        static void Bolme(double a, double b)
        {
            Console.WriteLine("Bölme işlemi yapılıyor...");
            double sonuc = a / b;
            Console.Write("İşlem sonucu: " + sonuc);
        }
    }
}
