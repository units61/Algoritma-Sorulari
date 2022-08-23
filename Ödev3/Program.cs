/*
    Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
    Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
    Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
*/

Console.Write("Kaç adet kelime girmek istediğinizi yazınız: ");
int diziSayisi = int.Parse(Console.ReadLine());

string[] kelimelerim = new string[diziSayisi];

Console.WriteLine($"{diziSayisi} kelimelik bir dizi oluşturdunuz!");

for (int i = 0; i < diziSayisi; i++)
{
    Console.Write($"{i + 1}. kelimeyi giriniz: ");
    kelimelerim[i] = Console.ReadLine();
}

Array.Reverse(kelimelerim);

Console.WriteLine("Girilen kelimeler sondan başa doğru...");
foreach (var kelime in kelimelerim)
{
    Console.WriteLine(kelime);
}