using GenericList;

    List<Araba> cars = new List<Araba>
        {
            new Araba { marka = "Toyota", model = "Corolla", benzinHarcamasi = 6.5, toplamMesafe = 6000 },
            new Araba { marka = "BMW", model = "X5", benzinHarcamasi = 9.0, toplamMesafe = 4250 },
            new Araba { marka = "Mercedes", model = "C200", benzinHarcamasi = 8.2, toplamMesafe = 5100 }
        };

    foreach (Araba car in cars)
    {
        double toplamYakit = car.ToplamYakitTuketimi();
        Console.WriteLine($"Marka: {car.marka}, Model: {car.model}, 100 km'de Yaktığı Yakıt: {car.benzinHarcamasi} litre, Toplam Yakıt Tüketimi: {toplamYakit} litre");
    }