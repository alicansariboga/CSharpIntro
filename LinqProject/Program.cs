using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    public class Program
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
            //METHODS

            //GetProducts(products);

            //Test(products);

            //AnyTest(products);

            //FindTest(products);

            //FindAllTest(products);

            //AscDescTest(products);

            // the old(another) syntax for linq's
            var result = from p in products
                         where p.UnitPrice>6000 && p.ProductName.Contains("fon")
                         //orderby p.UnitPrice (default = ascending)
                         //orderby p.UnitPrice descending
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select p;
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

        }

        private static void AscDescTest(List<Product> products)
        {
            // C# is a keysense language. So, it is important that lower case and upper case letters.
            // It is where instead of FindAll.
            // the order of the list at the end of loop is for alphabetic.
            // We should use OrderBy(Ascending/ descending) to order the queue.
            //var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p=>p.UnitPrice);
            // if the prices are equals, we can order another parameters with thenBy (ascending/ descending)
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            // works as where condition
            var result = products.FindAll(p => p.ProductName.Contains("Tel"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            //predicate =>(lambda)
            var result = products.Find(p => p.ProductId == 2);
            Console.WriteLine(result);
            // LinqProject.Product => Here we reach the product itself. Performs the search. You can olso also access the desired information by providing features though the process with "." .
        }

        private static void AnyTest(List<Product> products)
        {
            var productControl = products.Any(p => p.ProductName == "Samsung Telefon"); // checks its existence
            Console.WriteLine(productControl);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algorithmic ------------------------");
            foreach (var product in products)
            {
                //filtering
                if (product.UnitPrice >= 18000 && product.UnitInStock >= 15)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            //Instead of coding of a lot of line with if-else block, we can use Linq structure to create projects with less code and more regular.
            Console.WriteLine("Linq ------------------------");
            var result = products.Where(p => p.UnitPrice > 18000 && p.UnitInStock > 15 && p.UnitInStock > 10);
            //actually, there is a new list with linq.
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
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
