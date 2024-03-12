//Bilgisayarın tuttuğu 1-100 arasındaki rastgele sayıyı, kullanıcıdan alan ve karşılaştıran, 10 tahmin hakkı veren ve kullanıcı sayıyı doğru tahmin ettiğinde kaçıncı tahminde bulduğunu ekrana yazan, 10 hak bittiğinde tahmin edememişse kullanıcıya olumsuz mesaj veren ve kullanıcının girdiği sayıya göre yönlendirme yapan algoritma ve akış diyagramı.



Random rnd = new Random(); //// Sınıftan nesne oluşturulur. // Random sınıfından rnd adında random tipinde rnd nesnesi oluşturuluyor. 
int randomsayi = rnd.Next(1, 101);
int sayac = 1;
Console.WriteLine("********SAYI TAHMİN OYUNU***********");

Console.WriteLine("Lütfen 1. Sayıyı Giriniz :");
don:
int sayi1 = Convert.ToInt32(Console.ReadLine());


if (sayac <= 10)
{

    if (sayi1 == randomsayi)
        Console.WriteLine("Tebrikler Bildiniz!! " + sayac + ".tahmininde doğru bildiniz.");
    else if (sayi1 > randomsayi)
    {
        Console.WriteLine("Lütfen daha Küçük bir sayi giriniz");
        sayac++;
        goto don;
    }
    else
    {
        Console.WriteLine("Lütfen daha büyük bir sayi giriniz");
        sayac++;
        goto don;
    }

}
else
    Console.WriteLine("Tüm Kullanım haklarınızı Kullandınız. Kaybettiniz !!!");