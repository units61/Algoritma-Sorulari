/* 
    Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
    Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
    Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
*/

Console.Write("Lütfen oluşturmak istediğiniz dizinin eleman sayısını giriniz: ");
int sayıDizisi = int.Parse(Console.ReadLine());

Console.Write("Lütfen bölme testi için bir pozitif bir bölen(sayı) giriniz: ");
int sayi = int.Parse(Console.ReadLine());

int[] bolunenler = new int[sayıDizisi];

for (int i = 0; i < sayıDizisi; i++)
{
    Console.Write($"Lütfen bölünen değeri için {i + 1}. sayıyı giriniz: ");
    bolunenler[i] = int.Parse(Console.ReadLine());
}

foreach (var bolunen in bolunenler)
{
    if ( bolunen % sayi == 0)
    {
        Console.WriteLine($"{bolunen}, tam bölmektedir!");
    }
}