using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.DataAccess
{
    public class XProductDal : IProductDal
    {
        public List<Product> _products;
        public XProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1, ProductName="Acer x Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitsInStock=2 },
                new Product{ProductId=2, ProductName="Asus x Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitsInStock=3 },
                new Product{ProductId=3, ProductName="HP x Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitsInStock=0 },
                new Product{ProductId=4, ProductName="Mac x Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitsInStock=1 },
                new Product{ProductId=5, ProductName="Dell x Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitsInStock=4 }
            };
        }
        public void Add(Product product)
        {
            // test // throw new Exception("Can't connect to database. ****** password is no correct.");
            Console.WriteLine("Product is added with X.");
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
