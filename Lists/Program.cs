using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[] { "Ankara","Istanbul", "Izmir" };
            Console.WriteLine(sehirler.Length);

            sehirler = new string[4];
            sehirler[3] = "Bursa";

            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            List<string> sehirler2 = new List<string>() {"Ankara","Istanbul","Izmir" };
            Console.WriteLine(sehirler2.Count);
            sehirler2.Add("Bursa");
            foreach (var sehir in sehirler2)
            {
                Console.WriteLine(sehir);
            }
            sehirler2.Add("Adana");
            Console.WriteLine(sehirler2.Count);
            bool sonuc1 = sehirler2.Contains("Izmir");
            Console.WriteLine(sonuc1);
            bool sonuc2 = sehirler2.Contains("Kayseri");
            Console.WriteLine(sonuc2);
        }
    }
}
