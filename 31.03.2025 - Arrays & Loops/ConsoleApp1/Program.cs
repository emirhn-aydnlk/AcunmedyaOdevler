int[] array = new int[5];
int toplam = 0;

for (int i=0; i<array.Length; i++)
{
    Console.WriteLine(i + 1 + ". sayıyı girin: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    toplam += array[i];
}
Console.WriteLine("sayilarin ortalamasi : " + toplam / 5);