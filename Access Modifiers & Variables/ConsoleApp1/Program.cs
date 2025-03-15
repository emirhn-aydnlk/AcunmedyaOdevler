/* C# dilinde erişim belirleyiciler, sınıf üyelerine (örneğin, yöntemler, değişkenler) hangi kod parçalarının erişebileceğini belirler.
Bu, kodunuzu düzenli, güvenli ve esnek tutmanızı sağlar.

1. Public
Tanım: Public üyeler, projedeki her yerden erişilebilir. Bu, herkese açık hale getirilen özellikler içindir.
Gerçek Hayat Örneği: Bir okulun ana kapısını düşünün. Okulun herkesin girebilmesi için açık tuttuğu bir ana kapısı vardır.
                     Bu kapı, erişim açısından "public" olarak tanımlanabilir.

2. Private
Tanım: Private üyeler yalnızca tanımlandıkları sınıf içinde kullanılabilir. Bu, sınıfın kendi işleyişini gizlemek ve dışarıdan erişime
       kapatmak için kullanılır.

Gerçek Hayat Örneği: Okulun müdür odasındaki kasa, yalnızca müdür tarafından erişilebildiği için "private" olarak düşünülebilir.

3. Protected
Tanım: Protected üyeler, yalnızca tanımlandıkları sınıfta veya o sınıftan türetilen alt sınıflarda kullanılabilir. Bu, miras alınan
       sınıfların belirli verilere erişimini sağlamak için kullanılır.

Gerçek Hayat Örneği: Bir aile içinde kullanılan özel bir aile reçetesi, yalnızca o ailenin üyeleri (sınıf ve alt sınıfları) tarafından
                     bilinir ve kullanılır.

4. Internal
Tanım: Internal üyeler yalnızca aynı proje veya derleme içerisinde kullanılabilir. Dış projelerden erişim mümkün değildir.

Gerçek Hayat Örneği: Bir şirketin içindeki çalışanlara özel bir web portalı düşünün. Bu portal yalnızca şirket içindekiler tarafından
                     erişilebilir ve dışarıdan erişim engellenmiştir. */



using ConsoleApp1;
using System;

class main
{
    static void Main()
    {
        Kullanici user = new Kullanici();

        user.BilgileriGoster();
    }
}