using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Degiskenler
            int deger1 = 155555;
            double deger2 = 15.8;
            string deger3 = "Merhaba";
            byte deger4 = 255;
            float deger6 = 15526;

            //---------------------------------

            //Boolean (Mantiksal true/false)
            bool degerx = true;
            bool degery = false;

            double piyasaDun = 115000.6;
            double piyasaBugun = 116000;

            bool sonuc = piyasaBugun > piyasaDun;
            // (!=) farkliysa demektir.

            string mesajArtis = "Artis";
            string mesajAzalis = "Azalis";
            string mesajEsit = "Ayni";

            if (sonuc == true)
            {
                Console.WriteLine(mesajArtis);
            }
            else if (piyasaBugun == piyasaDun)
            {
                Console.WriteLine(mesajEsit);
            }
            else
            {
                Console.WriteLine(mesajAzalis);
            }

            //---------------------------------

            
        }
    }
}
