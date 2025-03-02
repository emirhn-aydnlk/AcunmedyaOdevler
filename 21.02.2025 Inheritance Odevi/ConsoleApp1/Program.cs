// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Classes;

Bmw a = new Bmw();
a.vites = "düz";
a.marka = "BMW";
a.yaz(a.vites,a.marka);

Mercedes b = new Mercedes();
b.vites = "otomatik";
b.marka = "Mercedes";
b.yaz(b.vites, b.marka);

Toyota c = new Toyota();
c.vites = "otomatik";
c.marka = "Toyota";
c.yaz(c.vites, c.marka);
