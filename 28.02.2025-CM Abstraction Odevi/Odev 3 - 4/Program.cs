using Odev_3___4.Abstracts;

Bmw bmw = new Bmw();
Mercedes mercedes = new Mercedes();
Porsche porsche = new Porsche();

double toplamYakitTukteimi = 0.0;
toplamYakitTukteimi += bmw.yakitTuketimi() * bmw.surusSaati();
toplamYakitTukteimi += mercedes.yakitTuketimi() * mercedes.surusSaati();
toplamYakitTukteimi += porsche.yakitTuketimi() * porsche.surusSaati();

Console.WriteLine("Toplam Yakıt Tüketimi: " + toplamYakitTukteimi);

/*C# dilinde bir Array (Dizi), aynı türden birden fazla değeri bir arada tutan bir veri yapısıdır. Diziler, bellekte ardışık alanlar kullanılarak saklanır ve
 * her bir elemana sıfırdan başlayan bir indeks numarası ile erişilir. Örneğin, bir tam sayı dizisi tüm elemanları int tipinde tutar.

Diziler genellikle şu durumlarda kullanılır:

    Aynı türden verileri saklamak.

    Hızlı bir şekilde verilere erişmek.

    Döngülerle veri setlerini işlemek.

Bir dizi tanımlarken türü, boyutu ve isteğe bağlı olarak içeriği belirtilir. */


