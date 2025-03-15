//ODEV 1

using ConsoleApp1.Odev_1;
using ConsoleApp1.Odev_2;

Kapi kapi = new Kapi(4);
Pencere pencere = new Pencere(4);
Kasa kasa = new Kasa("Sedan");
Fiyat fiyat = new Fiyat(2000000);

Araba araba = new Araba(fiyat, kapi, kasa, pencere);

YeniAraba yeniAraba = new YeniAraba(araba, "BMW", "X5");

yeniAraba.arabaBilgileri();



//ODEV 2

Matematik matematik = new Matematik();

Console.WriteLine(matematik.carp(3.14, 2.81)); //2 double parametreli carpma
Console.WriteLine(matematik.carp(4,8,15)); //3 int parametre alan carpma islemi

Console.WriteLine(matematik.topla(4, 98)); //2 int parametre alan toplama islemi
Console.WriteLine(matematik.topla(3, 8347, 436)); //3 int parametre alan toplama işlemi



//ODEV 3

/*Garbage Collector (GC), bellekte kullanılmayan nesneleri otomatik olarak temizleyen bir mekanizmadır. Bu, uygulamanın bellek yönetimini
 kolaylaştırır ve geliştiricilerin manuel olarak bellek tahsisi ve temizleme işlemleriyle uğraşmasını engeller.

En basit haliyle, şöyle çalışır:

Nesne Oluşturma: Kod çalışırken yeni nesneler bellekte oluşturulur.

Ulaşılabilirlik Kontrolü: GC, bellekteki nesneleri izler. Eğer bir nesneye artık hiçbir referans yoksa
                          (yani kodda kullanılmıyor veya erişilemiyor), o nesne "çöp" olarak kabul edilir.

Temizlik: GC, çöp olarak işaretlenen nesneleri bellekte temizler ve bu alanı başka nesnelerin kullanması için
          yeniden kullanılabilir hale getirir.

Optimizasyon: Performansı artırmak için GC, bu işlemleri gerektiği zaman, genellikle sistemin boş olduğu anlarda çalıştırır.

Bu sistem, bellek sızıntılarını önlemeye yardımcı olur ve yazılımcıya zaman kazandırır. Ancak, hangi nesnelerin
ne zaman temizleneceği tamamen GC'nin kontrolündedir. Bu yüzden, bellek yönetimine dikkat etmeyi gerektiren durumlar da olabilir.


-------------------------------------------------------------------------

Garbage Collector (GC), bellek yönetiminde kritik bir rol oynar çünkü uygulamalardaki bellek kaynaklarının etkin ve güvenli bir şekilde
kullanılması için çalışır. İşte bu roldeki önemli noktalar:

Otomatik Hafıza Temizliği: GC, artık kullanılmayan nesneleri tespit edip belleği serbest bırakır. Bu, geliştiricinin manuel olarak
                           belleği yönetme ihtiyacını azaltır ve bellek sızıntılarını önler.

Bellek Tüketiminin Azaltılması: Bellek etkin bir şekilde geri kazanıldığı için, uygulamanın gereksiz yere daha fazla bellek tüketmesi önlenir.

Uygulama Kararlılığı: Bellek yönetimini kontrol altına alarak, uygulamanın performans düşüşü veya çökme gibi sorunlarla
                      karşılaşma ihtimalini azaltır.

Geliştiriciye Kolaylık: GC, bellek yönetimi yükünü devralarak geliştiricilere, uygulamanın mantığı ve işlevselliği üzerine
                        daha fazla odaklanma imkânı sağlar.

Ancak, şunu unutmamak gerekir: GC her ne kadar otomatik bir mekanizma olsa da, uygunsuz bellek kullanımı (örneğin, büyük miktarda
bellek tahsisi yapmak ve uzun süre bırakmak) performans sorunlarına yol açabilir. Dolayısıyla, bellek yönetimi için iyi kodlama
alışkanlıkları geliştirmek hâlâ önemlidir.  */



//ODEV 4

/* Generic yapılar, yazılım geliştirmede esneklik, performans ve kodun yeniden kullanılabilirliği gibi birçok avantaj sağlar. Generic yapıların
başlıca avantajları:

Tür Güvenliği (Type Safety): Generic yapılar, derleme zamanı (compile-time) tür kontrolü sağlar. Bu, yanlış veri tipi atanması nedeniyle
                             oluşabilecek hataları önler ve kodun daha güvenilir olmasını sağlar.

Kod Yeniden Kullanılabilirliği: Generic yapılar, bir kez yazıldığında farklı veri tipleriyle kullanılabilir. Bu da aynı işlevi gerçekleştiren
                                farklı türler için ayrı ayrı kod yazma ihtiyacını ortadan kaldırır.

Daha Az Hata: Generic yapılar, tür dönüştürme (casting) ihtiyacını azaltır. Dönüştürme işlemleri sırasında oluşabilecek hatalardan kaçınılır.

Performans: Generic yapılar, kutulama (boxing) ve açma (unboxing) işlemlerinden kaçınır, özellikle değer tipleriyle (value types) çalışırken
            daha iyi performans sunar. Örneğin, bir int değeri generic bir listeye eklenirken kutulama gerekmez.

Bakım Kolaylığı: Generic yapılar, kodun daha temiz ve anlaşılır olmasını sağlar. Bu, kodun bakımını ve genişletilmesini kolaylaştırır.

Esneklik: Generic sınıflar, metotlar ve arayüzler farklı türlerle çalışabilme yeteneği sayesinde esneklik sağlar.

<------------- ORNEK ------------>

public class GenericClass<T>
{
    public T Value { get; set; }

    public void ShowValue()
    {
        Console.WriteLine($"Value: {Value}");
    }
}

// Kullanımı:
GenericClass<int> intGeneric = new GenericClass<int>();
intGeneric.Value = 10;
intGeneric.ShowValue(); // Output: Value: 10

GenericClass<string> stringGeneric = new GenericClass<string>();
stringGeneric.Value = "Merhaba!";
stringGeneric.ShowValue(); // Output: Value: Merhaba!

------------------------------------------------------------------------

Boxing ve Unboxing, C# dilinde değer tipleri (value types) ile referans tipleri (reference types) arasında
veri dönüştürme işlemlerini ifade eder.

Boxing, bir değer tipinin (örneğin, int, double) bir referans tipine (örneğin, object) dönüştürülmesidir.
Bu işlem sırasında, değer tipi bir kutuya (heap'te bir nesne) yerleştirilir.

int number = 42;
object boxed = number; // Boxing işlemi


Unboxing, bir referans tipinden (örneğin, object) orijinal değer tipine geri dönüştürülmesidir. Bu işlem,
kutulanmış (boxed) bir nesneyi alır ve onu bir değer tipine dönüştürür.

object boxed = 42; 
int unboxed = (int)boxed; // Unboxing işlemi  */




