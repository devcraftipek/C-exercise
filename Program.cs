using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Kullanıcıdan isim, yaş ve eğitim bilgilerini isteyip ehliyet alabilme 
            // durumunu kontrol ediniz. Ehliyet alma koşulu en az 18 ve eğitim durumu 
            // lise ya da üniversite olmalıdır. 

            // Console.Write("ad: ");
            // string ad = Console.ReadLine();

            // Console.Write("yaş: ");
            // int yas = int.Parse(Console.ReadLine());

            // Console.Write("eğitim durumu: ");
            // string egitim = Console.ReadLine();

            // if (yas>=18)
            // {
            //     // eğitim bilgisini kontrol et.
            //     if (egitim=="lise" || egitim=="üniversite")
            //     {
            //         Console.WriteLine($"{ad} ehliyet alabilirsiniz.");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"{ad} ehliyet almak için eğitim durumunuz yetersiz.");    
            //     }
            // }
            // else{
            //     Console.WriteLine($"{ad} ehliyet almak için en az 18 olmalısınız.");
            // }

            // 2- Girilen 3 sayıdan en büyüğünü bulunuz.

                // Console.Write("a: ");
                // int a = int.Parse(Console.ReadLine());

                // Console.Write("b: ");
                // int b = int.Parse(Console.ReadLine());

                // Console.Write("c: ");
                // int c = int.Parse(Console.ReadLine());

                // if (a>b && a>c)
                //     Console.WriteLine("a en büyük");
                // else if (b>a && b>c)
                //     Console.WriteLine("b en büyük");
                // else if (c>a && c>b)
                //     Console.WriteLine("c en büyük");
                // else
                //     Console.WriteLine("yanlış bilgi");

            // 3- Bir öğrencinin 2 yazılı bir sözlü notunu alıp hesaplanan ortalamaya göre
            // not aralığına karşılık gelen not bilgisini yazdırınız.

            // 0 -24  => 0
            // 25-44  => 1
            // 45-54  => 2
            // 55-69  => 3
            // 70-84  => 4
            // 85-100 => 5

            // Console.Write("1. yazılı: ");
            // int not1 = int.Parse(Console.ReadLine());
            // Console.Write("2. yazılı: ");
            // int not2 = int.Parse(Console.ReadLine());
            // Console.Write("sözlü: ");
            // int sozlu = int.Parse(Console.ReadLine());

            // var ortalama = (not1+not2+sozlu)/3;
            // int not=-1;

            // if (ortalama>=0 && ortalama<25)
            //     not = 0;
            // else if (ortalama>=25 && ortalama<45)
            //     not = 1;
            // else if (ortalama>=45 && ortalama<55)
            //     not = 2;
            // else if (ortalama>=55 && ortalama<70)
            //     not = 3;
            // else if (ortalama>=70 && ortalama<85)
            //     not = 4;
            // else if (ortalama>=85 && ortalama<100)
            //     not = 5;
            // else 
            //     Console.WriteLine("yanlış not");

            // Console.WriteLine($"not ortalamalası: {ortalama} ve notunuz: {not}");
            

            // 4- Trafiğe çıkış tarihi alınan bir aracın servis zamanını 
            //    aşağıdaki bilgilere göre hesaplayınız.
            //    1. Bakım => 1. yıl     
            //    2. Bakım => 2. yıl      
            //    3. Bakım => 3. yıl     
            //    ** Süre hesabını alınan gün, ay, yıl bilgisine göre gün bazlı hesaplayınız..        

            Console.Write("yıl: ");
            int yil = int.Parse(Console.ReadLine());

            Console.Write("ay: ");
            int ay = int.Parse(Console.ReadLine());

            Console.Write("gün: ");
            int gun = int.Parse(Console.ReadLine());

            int toplamGun = (DateTime.Now - new DateTime(yil,ay,gun)).Days;

            if (toplamGun<=365)
                Console.WriteLine("1.servis");
            else if(toplamGun>365 && toplamGun<=365*2)
                Console.WriteLine("2.servis");
            else if(toplamGun>365*2 && toplamGun<=365*3)
                Console.WriteLine("3.servis");
            else
                Console.WriteLine("yanlış bilgi");



        }
    }
}
