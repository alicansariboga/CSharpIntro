using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            int sonuc1 = matematik.Topla(3, 5);
            int sonuc2 = matematik.Topla(10);
            int sonuc3 = matematik.Topla(sayi2:15, sayi1:8); // bu sekidl ekarisik vermek icin de : ile deger atamasi yapilir.
            
            Console.WriteLine(sonuc1);
            Console.WriteLine(sonuc2);
            Console.WriteLine(sonuc3);

            int sonuc4 = matematik.Topla2(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }); //array gibi veya normal olarak veri girilebilir.
            int sonuc5 = matematik.Topla2(1, 2, 3, 4, 5, 6, 7, 8);

        }
    }

    //Overloading
    class Matematik
    {
        // public void olursa eger bir sey dondurmedigimiz anlamina gelir.
        // Ama bir sonuc dondureceksek yani return kullanacaksak, void yerine donecek degerin turu atanir.
        public int Topla(int sayi1=0, int sayi2=0)
            // burada yapilan atama default degerdir. deger atamasi yapilmazsa 0 olarak alinir.
        {
            return sayi1 + sayi2;
        }

        //ONEMLI: C# DA IKI METHOD OLABILIR. TEK SSART ISE ALDIGI PARAMETRELER FARKLI OLACAK. BU DURUM OVERLOADING SAYESINDE OLUR.
        public int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2;
        }

        //Params = 2 veya 3 ten daha fazla toplama yapilacak. Her secenek icin overloading yapilip method yazilamaz. Kisayol olarak params kullanilir.
        public int Topla2(params int[] sayilar) //aslinda array gonderiliyor gibi dusunulebilir.
        {
            
            //dongu ile toplanabilir.
            int sonuc = 0;
            /*
            foreach (var sayi in sayilar)
            {
                sonuc = sonuc + sayi;
            }
            Console.WriteLine(sonuc);
            return sonuc; */
            return sayilar.Sum(); // with using System.Linq.

        }

        public int Cikar(int sayi1=0, int sayi2=0)
        {
            return sayi1 - sayi2;
        }
    }

}
