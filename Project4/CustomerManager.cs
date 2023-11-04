using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class CustomerManager //CustomerService
    {
        //Constructor 'ctor'
        public CustomerManager()
        {
            //Constructor arka planda her zaman calisir fakat projede GetAll() her cagrilmasinda list sifirlanir. Bundan dolayi list contructor icerisinde cagirilir.
            customers = new List<Customer>()
            {
                new Customer{Id=1, FirstName="Ali Can", LastName="Sariboga", City="Adana", Email="alican@gmail.com" },
                new Customer{Id=2, FirstName="Ahmet", LastName="Can", City="Ankara", Email="alican@gmail.com" },
                new Customer{Id=3, FirstName="Ezgi", LastName="Kok", City="Bursa", Email="alican@gmail.com" },
                new Customer{Id=4, FirstName="Rasit", LastName="katli", City="Mersin", Email="alican@gmail.com" },
                new Customer{Id=5, FirstName="Sena", LastName="Gizem", City="Kayseri", Email="alican@gmail.com" }
            };
        }

        //Listeye Add() fonksiyonundan erisim icin listenin public olmasi gereklmektedir.
        List<Customer> customers;
        public List<Customer> GetAll()
        {
            //Genelde Veritabani Baglanti Yapilir.

            return customers;
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
