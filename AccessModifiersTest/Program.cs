using AccessModifiers; //reference
using System;

namespace AccessModifiersTest
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.Id = 1;
            house.City = "Ankara";
            Console.WriteLine("Hello World!");
        }
    }
}
