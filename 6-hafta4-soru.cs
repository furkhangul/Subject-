using System;

class Program
{
    static void Main()
    {
        int rastgeleSayi = 41;
        //Hoca burayı sabit bir sayı girebiliriz dedi
        int sayac = 0;

        while (true) 
        {
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            string kullanicidegeri = Console.ReadLine();
            if (rastgeleSayi == int.Parse(kullanicidegeri))
            {
                sayac++;
                break;
            }
            else
            {
                if (rastgeleSayi < int.Parse(kullanicidegeri)){
                    Console.WriteLine("Lütfen daha küçük bir sayı giriniz !");
                    sayac++;
                }
                else if(rastgeleSayi > int.Parse(kullanicidegeri)){
                    Console.WriteLine("Lütfen daha büyük bir sayı giriniz !");
                    sayac++;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş");
                    sayac++;
                }
            }


        }


        Console.WriteLine("Doğru Değeri {0}. denemede buldunuz.", sayac);
        
        
        
        Console.ReadLine();
    }
}
