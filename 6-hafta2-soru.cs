using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir kullanıcı adı girin:");
        string username = Console.ReadLine();
        while (true)
        {
            if (username.Length <= 5)
            {
                Console.WriteLine("Lütfen 5 karakterden uzun kullanıcı adı seçiniz !");
                Console.WriteLine("Lütfen bir kullanıcı adı girin: ");
                username = Console.ReadLine();
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("Lütfen bir e posta adresi  girin:");
        string eposta = Console.ReadLine();

        for (int i = 0; i < eposta.Length; i++)
        {

            char harf = eposta[i];
            if (harf == '@')
            {
                for (int k = 0; k < eposta.Length; k++)
                {
                   
                    char harf2 = eposta[k];
                    if (harf2 == '.')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hata! eposta adresinizde . ifadesi kullanılmıyor.");
                        break;
                    }

                }

            }
            else
            {
                Console.WriteLine("Hata! eposta adresinizde @ ifadesi kullanılmıyor.");
                break;

            }

        }

        while (true)
            {
        Console.WriteLine("Lütfen yaşınızı  giriniz:");
            string age = Console.ReadLine();
            if (int.Parse(age) > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Yaşınız 0 dan küçük olamaz !");
                }
            }

            Console.WriteLine("Başarılı Giriş !");


            Console.ReadLine();
        }
    }
