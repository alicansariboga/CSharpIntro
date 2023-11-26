using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.DataAccess
{
    public class EfProductDal : IProductDal
    {
        public List<Product> _products;
        public EfProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1, ProductName="Acer ef Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitInStock=2 },
                new Product{ProductId=2, ProductName="Asus ef Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitInStock=3 },
                new Product{ProductId=3, ProductName="HP ef Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitInStock=0 },
                new Product{ProductId=4, ProductName="Mac ef Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitInStock=1 },
                new Product{ProductId=5, ProductName="Dell ef Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitInStock=4 }
            };
        }
        public void Add(Product product)
        {
            Console.WriteLine("Product is added with EF.");
        }

        public List<Product> GetAll()
        {
            return _products;
        }
    }
}
