using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, boolean = value types
            // stored in stack.
            int num1 = 10;
            int num2 = 20;

            num1 = num2;
            num2 = 100;

            Console.WriteLine("Number 1 :" + num1);

            //Arrays, classes, interfaces ,... = reference types
            //stored in heap.(adressing)
            int[] numbers1 = new int[] { 1, 2, 3 };
            int[] numbers2 = new int[] { 10, 20, 30 };

            numbers1 = numbers2;
            numbers2[0] = 100;
            numbers1[0] = 200; //doesn't matter
            Console.WriteLine("Numbers 1 :" + numbers1[0]);
            foreach (var number in numbers1)
            {
                Console.WriteLine(number);
            }

            /* ---------------------------------------------------------------------------------- */

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Ali Can";
            person2 = person1; // Address synchronization is done, not value synchronization.
             person1.FirstName = "Can";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.CreditCartNumber = 123465789;
            customer.FirstName = "Umut";

            Employee employee = new Employee();
            employee.FirstName = "Ayse";

            // customer = employee; => doesn't assign
            Person person3 = customer; // with inheritance.
            Console.WriteLine(customer.CreditCartNumber);
            //Console.WriteLine(person3.CreditCartNumber);//ERROR => although assign, the process doing on the person pattern.
            //Boxing
            Console.WriteLine(((Customer)person3).CreditCartNumber); //in this time, given customer features to person3.

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(customer);
            personManager.Add(employee);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string NationalIdentity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public int CreditCartNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person) // alike both customer and employee
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
