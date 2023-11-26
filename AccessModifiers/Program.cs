using System;

namespace AccessModifiers
{
    // private => in class
    // proteted => in class and inheritance
    // internal(default) => in namespace
    // public => in project
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    internal class Customer
    {
        
    }
}
