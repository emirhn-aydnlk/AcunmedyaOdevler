using MatematikIslemleri;
using System;

namespace MatematikIslemleri
{
    public class Hesaplama
    {
        public void Topla(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        public void Carp(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 * sayi2);
        }
    } 
}

namespace ProgramTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Hesaplama hesaplama = new Hesaplama();

            hesaplama.Topla(5, 5);
            hesaplama.Carp(5, 5);  
        }
    }
}
