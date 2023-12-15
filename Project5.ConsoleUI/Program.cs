using Project5.Business;
using Project5.DataAccess;
using Project5.Entities;
using System;

namespace Project5.ConsoleUI
{
    //For example x framework. Well it's the impportant thing that called maintainability.
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetAllAsync().Result)
            {
                Console.WriteLine(item.ProductName);
            }

            // The ProductId value will be automatically assigned in SQL during the adding process.
            // However, the ProductId value must be given for update and delete operations.
            //Only ProductId is sufficient for deletion. It is stated as such in EfProduckDal.

            //productManager.Add(new Product { ProductName = "Masa1", CategoryId = 4, QuantityPerUnit = "4 ayakli masa", UnitsInStock = 40, UnitPrice = 1000 });

            // productManager.Update(new Product { ProductId= 79,ProductName = "Masa2", CategoryId = 2, QuantityPerUnit = "6 ayakli masa", UnitsInStock = 15, UnitPrice = 1200 });
            Console.WriteLine(productManager.GetById(1).ProductName); // only product according to ProductId


            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            //try
            //{
            //productManager.Add(new Product { ProductId = 1, ProductName = "Masa", QuantityPerUnit = "4 ayakli masa", UnitsInStock = 1000, UnitPrice = 500 });
            //}
            ////catch (Exception exception)
            //catch (DublicateProductException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            // For Mapping
            PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
            foreach (var personel in personelManager.GetAll())
            {
                Console.WriteLine(" {0} / {1} / {2} ",personel.PersonelId, personel.PersonelName, personel.PersonelSurname);
            }

        }
    }
}
