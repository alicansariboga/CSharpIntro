using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ADO.NET => it is library for db processes (More code)
            // .Entity Framework => ORM - Object Relational Mapping (Less code)
            // NHibernate (alternative for EF)
            // Dapper (alternative for ADO.NET)

            //GetAll();
            GetProductsByCategory(1);
        }

        private static void GetAll()
        {
            NorthWindContext northWindContext = new NorthWindContext();

            foreach (var product in northWindContext.Products)
            {
                Console.WriteLine(product.ProductID + " " + product.ProductName);
            }
        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthWindContext northWindContext = new NorthWindContext();

            var result = northWindContext.Products.Where(p => p.CategoryID == categoryId);
            foreach (var product in result) 
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
