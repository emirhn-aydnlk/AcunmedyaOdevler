using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Odev_2
{
    public class Matematik
    {
        public int topla(int a, int b)
        {
            return a + b;   
        }

        public int topla(int a, int b, int c)
        {
            return a + b + c;
        }

        public double carp(double a, double b)
        {
            return a * b;
        }

        public int carp(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}
