using System;

namespace Classes2
{
    class Program
    {
        //Instance // ornek
        static void Main(string[] args)
        {
            Product product1 = new Product() { ProductName="Laptop", UnitPrice=5000, UnitsInStock=5 };
            Product product2 = new Product() { ProductName="Masaustu PC", UnitPrice=5000, UnitsInStock=5 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);
        }
    }
}
