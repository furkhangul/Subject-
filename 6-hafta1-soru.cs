using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir dizi sayı girin. Sayıları boşlukla ayırın ve 'bitti' yazarak girişi bitirin.");
        int? minimumDeger = null;
        int? maksimumDeger = null;

        while (true)
        {
            string deger = Console.ReadLine();

            if (deger == "bitti")
            {
                Console.WriteLine("Döngüyü Bitirdiniz !");
                Console.WriteLine("Minimum Değeriniz={0} \nMaksimum Değeriniz={1}", minimumDeger, maksimumDeger);
                break;
            }
            else
            {
                int sayi = int.Parse(deger);

                if (minimumDeger == null || sayi < minimumDeger)
                {
                    minimumDeger = sayi;
                }

                if (maksimumDeger == null || sayi > maksimumDeger)
                {
                    maksimumDeger = sayi;
                }
            }
        }

        Console.ReadLine();
    }
}
