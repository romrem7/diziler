internal class Program
{
    private static void Main(string[] args)
    {
        //Dizi Tanımlama
        string[] renkler = new string[5];

        string[] hayvanlar = {"kedi","köpek", "kuş","maymun"};

        int[] dizi;
        dizi = new int[5];

        //Dizilere Değere Atama ve Erişim
        renkler[0] = "Mavi";
       
        dizi[3] = 10;

         Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        //Döngülerle dizi kullanımı
        // Klavyeden girilen n tane sayının ortalamasını hesaplayan program
        Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
        int diziUzunlugu = int.Parse(Console.ReadLine());
    }
}