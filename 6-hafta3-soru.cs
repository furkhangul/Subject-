using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> asalSayilar = new List<int>();

        for (int i = 2; i <= 100; i++)
        {
            int sayac = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    sayac++;
                    if (sayac > 2)
                    {
                        break;
                    }
                }
            }
            if (sayac == 2)
            {
                asalSayilar.Add(i);
            }
        }

        foreach (int sayi in asalSayilar)
        {
            Console.WriteLine(sayi);
        }
        Console.ReadLine();
    }
}
