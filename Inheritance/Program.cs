using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PersonManager personManager = new PersonManager();
            personManager.Add();

            CustomManager customManager = new CustomManager();
            customManager.Add();
            customManager.GetBestCustomer();

            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.Update();
            employeeManager.GetBestEmployee();
        }
    }

    class PersonManager
    {
        public void Add()
        {
            Console.WriteLine("Added.");
        }
        public void Update()
        {
            Console.WriteLine("Updated.");
        }
    }
    class CustomManager:PersonManager //inheritance
    {
        public void GetBestCustomer()
        {

        }
    }
    class EmployeeManager:PersonManager
    {
        public void GetBestEmployee()
        {

        }
    }
    class Person
    {
        public int Id { get; set; } //DB No
        public string NationalIdentity { get; set; } //TCKN
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class Customer:Person
    {
        public int CreditCartNumber { get; set; }
    }
}
