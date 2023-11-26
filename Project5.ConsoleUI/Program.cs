using Project5.Business;
using Project5.DataAccess;
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
        }
    }
}
