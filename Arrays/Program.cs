using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kredi1 = "Hizli Kredi";
            //string kredi2 = "Ozel Firsatlar";
            //string kredi3 = "Konut Kredisi";

            //Console.WriteLine(kredi1);
            //Console.WriteLine(kredi2);
            //Console.WriteLine(kredi3);

            //Bu sekilde tek tek yazmak yerine arrya ler kullanilir.

            string[] krediler = new string[5];
            krediler[0] = "Hizli Kredi";
            krediler[1] = "Ozel Firsatlar";
            krediler[2] = "Ihtiyac Kredisi";
            krediler[3] = "Konut Kredisi";
            krediler[4] = "Tasit Kredisi";

            Console.WriteLine(krediler[0]);
            Console.WriteLine(krediler[1]);
            Console.WriteLine(krediler[2]);
            Console.WriteLine(krediler[3]);
            Console.WriteLine(krediler[4]);
        }
    }
}
