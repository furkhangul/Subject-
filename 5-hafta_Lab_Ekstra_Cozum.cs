using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir metin giriniz:");
        string girdi = Console.ReadLine();
            //ekstra dizi oluşturdum belki fazladan oldu ama aklıma ilk gelen yöntem buydu :)
        char[] dizi = new char[girdi.Length];


        for (int i = 0; i < girdi.Length; i++)
        {
            dizi[i] = girdi[i];
        }


        string cikti = ""; //farklı şekillerde oluşturulalbilirdi ama cikti boşluk olması fazla kod bırakmayacaktır. 
        int sayac = 1;
        for (int i = 0; i < dizi.Length - 1; i++)
        {
            if (dizi[i] == dizi[i + 1])
            {
                sayac++;
            }
            else
            {
                cikti += dizi[i] + sayac.ToString();
                sayac = 1;
            }
            Console.ReadLine();
        }
        cikti += dizi[dizi.Length - 1] + sayac.ToString();
        Console.WriteLine("Çıktı: " + cikti);
    }
}
