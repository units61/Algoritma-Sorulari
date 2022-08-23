/*
    Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
    Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
*/

Console.Write("Lütfen bir cümle yazınız: ");
string cumle = Console.ReadLine();
string[] kelimeler = cumle.Split(' ');
string harfler = string.Join("", kelimeler);

Console.WriteLine($"Girilen cümledeki toplam kelime sayısı: {kelimeler.Length}");
Console.WriteLine($"Girilen cümledeki toplam harf sayısı: {harfler.Length}");