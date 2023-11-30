using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category { CategoryId = 1, CategoryName="Bilgisayar" },
                new Category { CategoryId = 2, CategoryName="Telefon" },
                new Category { CategoryId = 3, CategoryName="Tablet" },
            };
            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1,CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32GB RAM", UnitPrice=15000, UnitInStock=20},
                new Product { ProductId = 2,CategoryId=1, ProductName="HP Laptop", QuantityPerUnit="32GB RAM", UnitPrice=18000, UnitInStock=0},
                new Product { ProductId = 3,CategoryId=1, ProductName="MSI Laptop", QuantityPerUnit="32GB RAM", UnitPrice=20000, UnitInStock=10},
                new Product { ProductId = 4,CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit="128GB RAM", UnitPrice=22000, UnitInStock=25},
                new Product { ProductId = 5,CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit="128GB RAM", UnitPrice=25000, UnitInStock=30},
                new Product { ProductId = 6,CategoryId=3, ProductName="Huawei Tablet", QuantityPerUnit="64GB RAM", UnitPrice=12000, UnitInStock=12},
            };
            Console.WriteLine("Algorithmic ------------------------");
            foreach (var product in products)
            {
                //filtering
                if(product.UnitPrice >= 18000 && product.UnitInStock>=15)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            //Instead of coding of a lot of line with if-else block, we can use Linq structure to create projects with less code and more regular.
            Console.WriteLine("Linq ------------------------");
            var result = products.Where(p=>p.UnitPrice>18000 && p.UnitInStock>15 && p.UnitInStock>10);
            //actually, there is a new list with linq.
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            GetProducts(products);
        }
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice >= 18000 && product.UnitInStock >= 15)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }
        // for linq
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 18000 && p.UnitInStock > 15 && p.UnitInStock > 10).ToList(); // IEnumerable structure means structure which can loop or iterate and So, this sentence should use with .ToList();
        }


    }
    class Product
    {
        public int ProductId { get; set; }
        //public string CategoryName { get; set; }
        public int CategoryId { get; set; } // relational database processes
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
