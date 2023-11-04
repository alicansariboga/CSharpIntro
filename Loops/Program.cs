using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] krediler = new string[5];
            krediler[0] = "Hizli Kredi";
            krediler[1] = "Ozel Firsatlar";
            krediler[2] = "Ihtiyac Kredisi";
            krediler[3] = "Konut Kredisi";
            krediler[4] = "Tasit Kredisi";

            for(int i=0; i<krediler.Length; i++)
                //burada i<5 de denilebilir fakat dizinin her zaman ne kadar uzunlukta olacagini bilemeyiz.
            {

                Console.WriteLine(krediler[i]) ;

            }
            Console.WriteLine("For Dongusu Bitti.");

            // var = otomatik tanimlama yapar. ornegin var ile tanimlanan deger int, string, bool vb. kendisi otomatik tanimlar.
            int x = 15;
            var y = 15;
            string xx = "xx";
            string yy = "xx"; 
            
            //foreach ozel bir for yapisidir. Diziler icin ozel tasarlanmistir.
            foreach (string kredi in krediler)
            {
                Console.WriteLine(kredi);
            }
            Console.WriteLine("Dongu Bitti.");

            // while ve DoWhile dongusu
            //Infinite loop
            /*
            while (true)
            {
                Console.WriteLine("X");
            }
            */

            Console.WriteLine("WHILE");
            int sayac = 0;
            while (sayac<7)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
            //for dongusunun aynisi.

            //Bunun amaci program yukardan asagiya calistigi icin sayac yanlis olsa bile dongunun ici 1 kez calistirilir.
            Console.WriteLine("DO WHILE");
            var sayac2 = 0;
            do
            {
                Console.WriteLine(sayac2);
                sayac2 = sayac2 + 1; //sayac2++
            } while (sayac2 < 7);

        }
    }
}
