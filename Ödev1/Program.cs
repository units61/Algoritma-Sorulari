﻿ //1. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
  //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
  //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            
            Console.WriteLine("Lütfen Dizinin eleman sayısını giriniz : ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int [diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }

            foreach (var sayi in sayıDizisi)
            {
                if (sayi % 2 == 0)
                    Console.WriteLine(sayi);
            }
