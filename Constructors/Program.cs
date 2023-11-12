using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // for default constructor
            Customer customer1 = new Customer { Id=1, FirstName="Ali Can", LastName="Sariboga", City="Adana" };
            Customer customer2 = new Customer(2, "Ali Can", "Sariboga", "Kayseri");
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Ali Can";
            customer3.LastName = "Sariboga";
            customer3.City = "Kayseri";

            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer // const for features
    {
        //Default Contructor (No parameter)
        public Customer()
        {

        }
        // Constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            //Console.WriteLine("Yapici blok.");
            // setting values
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
