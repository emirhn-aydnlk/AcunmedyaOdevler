namespace NumberGuessingGame;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();


        int randomNumber = random.Next(0,11); // 1 ile 10 arasında rastgele bir sayı üretmek için kullanılacak.
        int guessNumber = 0;
        int guessCount = 0;

        Console.WriteLine("Bilgisayar 1 ile 10 arasında bir sayı tuttu. Tahmin et bakalım!");

        while (guessNumber != randomNumber) // Bu döngü kullanıcı doğru tahmin yapana kadar devam eder.
        {
            guessNumber = Convert.ToInt32(Console.ReadLine()); // Hesap makinesi ödevinde öğrendiğimiz gibi kullanıcıdan tahmin alınır.
                                                               // İlk bu ödevden başlamışsanız hesap makinesinde zorlanmazsınız :)
            guessCount++;

            // if-else yapısı kullanarak kullanıcının tahminini kontrol edin ve büyük/küçük olduğunu belirtin.

            if (guessNumber < randomNumber)
            {
                Console.WriteLine("Daha büyük bir sayı giriniz.");
            }
            else if (guessNumber > randomNumber)
            {
                Console.WriteLine("Daha küçük bir sayı giriniz.");
            }
        }
        Console.WriteLine($"Tebrikler! {guessCount}. tahminde doğru sayıyı buldunuz.");
    }
}