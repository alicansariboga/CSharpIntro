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
            ProductManager productManager = new ProductManager(new XProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            try
            {
            productManager.Add(new Product { ProductId = 1, ProductName = "Masa", QuantityPerUnit = "4 ayakli masa", UnitInStock = 1000, UnitPrice = 500 });
            }
            //catch (Exception exception)
            catch (DublicateProductException exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
    }
}
