using GenericList;
using System.Diagnostics.Metrics;

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


//ODEV 2

/* Görsel programlama; yazılım geliştirme sürecinde, geleneksel metin tabanlı kodlama yerine görsel elemanların, grafiklerin ve simgelerin kullanıldığı bir yöntemdir. Bu yaklaşım, programlama sürecini daha sezgisel hale getirir ve genellikle sürükle-bırak arayüzler ile görsel bağlantılar üzerinden çalışır. Yazılımı görselleştirmek, kod yapısını anlamayı kolaylaştırır ve özellikle yeni başlayanlar için idealdir.

Kullanılan Araçlar ve Diller
Görsel programlama için çeşitli araçlar ve diller bulunmaktadır. İşte bazıları:

Scratch: Çocuklar ve yeni başlayanlar için basit, sürükle-bırak tabanlı bir dil.

Blockly: Google tarafından geliştirilen, web tabanlı görsel programlama.

LabVIEW: Mühendislik ve bilimsel araştırmalarda kullanılan bir grafiksel programlama aracı.

Unreal Engine (Blueprint): Oyun geliştirme sürecinde kullanılan, görsel akış tabanlı bir sistem.

Node-RED: IoT(nesnelerin interneti) ve veri akışı uygulamaları için popüler bir araç.

Avantajları
Kolaylık ve Öğrenim: Özellikle programlama öğrenmeye başlayanlar için sezgisel bir yapı sunar.

Hızlı Prototipleme: Karmaşık sistemlerin hızlı bir şekilde modellenmesini sağlar.

Kod Hatalarının Azalması: Görsel yapı sayesinde mantık hataları daha kolay tespit edilebilir.

Takım Çalışması: Teknik olmayan kişilerin de anlayabileceği görsel bir yapı sağlar.

Dezavantajları
Kısıtlılık: Bazı görsel araçlar, karmaşık projelerde yetersiz kalabilir.

Performans Sorunları: Metin tabanlı programlama dillerine göre genellikle daha az optimize edilmiş olabilir.

Esneklik Eksikliği: Geliştiriciler için belirli sınırlar ve kısıtlamalar oluşturabilir.

Büyük Ölçekli Projeler: Daha büyük ve karmaşık projelerde görsel programlama zorlayıcı hale gelebilir. */