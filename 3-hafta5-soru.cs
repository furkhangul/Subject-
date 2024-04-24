using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        DateTime date = new DateTime(2004, 11, 04);

        int yil = (now.Year - date.Year);
        int ay = (now.Month - date.Month);
        int gun = (now.Day - date.Day);

        Console.WriteLine("Farklılık: " + yil + " yıl, " + ay + " ay, " + gun + " gün");

        Console.ReadLine();
    }
}
