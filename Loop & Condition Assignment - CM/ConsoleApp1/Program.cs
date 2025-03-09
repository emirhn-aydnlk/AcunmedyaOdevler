using ConsoleApp1.Classes;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Odev numarası girin (1-5): ");

        int odevNo = int.Parse(Console.ReadLine());

        switch (odevNo)
        {
            case 1:
                Odev1();
                break;
            case 2:
                Odev2();
                break;
            case 3:
                Odev3();
                break;
            case 4:
                Odev4();
                break;
            case 5:
                Odev5();
                break;
            default:
                Console.WriteLine("Geçersiz odev numarası girdiniz!");
                break;
        }

    }

    static void Odev1()
    {
        //ODEV 1

        Console.Write("Lütfen yaşınızı girin: ");
        int yas = int.Parse(Console.ReadLine());

        string kategori = YasKategorisi(yas);

        Console.WriteLine(kategori);
    }

    static string YasKategorisi(int yas)
    {
        if (yas <= 18)
        {
            return "Küçüksünüz";
        }
        else if (yas <= 35)
        {
            return "Gençsiniz";
        }
        else if (yas <= 55)
        {
            return "Yetişkinsiniz";
        }
        else if (yas <= 75)
        {
            return "Yaşlısınız";
        }
        else if (yas <= 99)
        {
            return "Çok yaşlısınız";
        }
        else
        {
            return "Ya hiç doğmadınız ya da çoktan öldünüz...";
        }
    }

    static void Odev2()
    {
        //ODEV 2

        Console.WriteLine("Arabanızın model yılını girin: ");
        int yas = DateTime.Now.Year - int.Parse(Console.ReadLine());

        string kategori = ArabaKategorisi(yas);

        Console.WriteLine(kategori);

        static string ArabaKategorisi(int yas)
        {
            if (yas > 0 && yas <= 10)
            {
                return "Arabanız Yeni";
            }
            else if (yas > 10 && yas <= 20)
            {
                return "Servise götürmeniz gerekebilir";
            }
            else if (yas > 20 && yas <= 30)
            {
                return "Arabanız hurdaya çıkabilir";
            }
            else
            {
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
            }
        }
    }

    static void Odev3()
    {
        //ODEV 3

        int count = 5;

        while (count < 5)
        {
            Console.WriteLine("While Döngüsü: count = " + count);
            count++;
        }

        Console.WriteLine("While döngüsü tamamlandı.");

        int count2 = 5;

        do
        {
            Console.WriteLine("Do-While Döngüsü: count = " + count2);
            count2++;
        } while (count2 < 5);

        Console.WriteLine("Do-While döngüsü tamamlandı.");
    }

    static void Odev4()
    {
        //ODEV 4

        Calisan gm = new Calisan();
        gm.Ad = "Ahmet";
        gm.Soyad = "Yılmaz";
        gm.Departman = "Genel Müdür";
        gm.Meslek = "Genel Müdür";
        gm.Maas = 80000;

        Calisan m = new Calisan();
        m.Ad = "Mehmet";
        m.Soyad = "Yıldırım";
        m.Departman = "Müdür";
        m.Meslek = "Müdür";
        m.Maas = 60000;

        Calisan pr = new Calisan();
        pr.Ad = "Ahmet";
        pr.Soyad = "Yılmaz";
        pr.Departman = "Genel Müdür";
        pr.Meslek = "Genel Müdür";
        pr.Maas = 80000;

        Calisan s = new Calisan();
        s.Ad = "Mehmet";
        s.Soyad = "Yıldırım";
        s.Departman = "Müdür";
        s.Meslek = "Müdür";
        s.Maas = 60000;

        Console.WriteLine(gm.Maas + m.Maas + pr.Maas + s.Maas);
    }

    static void Odev5()
    {
        //ODEV 5

        Araba BMW = new Araba();
        BMW.yakitTuketimi = 20;

        Araba Mercedes = new Araba();
        Mercedes.yakitTuketimi = 15;

        Araba Porsche = new Araba();
        Porsche.yakitTuketimi = 18;

        Console.WriteLine(BMW.yakitTuketimi + Mercedes.yakitTuketimi + Porsche.yakitTuketimi);
    }
}

