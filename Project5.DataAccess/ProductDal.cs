using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.DataAccess
{
    public class ProductDal:IProductDal //data access layer
    {
        //Ado.Net - EntityFramework
        public List<Product> _products;
        public ProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1, ProductName="Acer Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitsInStock=2 },
                new Product{ProductId=2, ProductName="Asus Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitsInStock=3 },
                new Product{ProductId=3, ProductName="HP Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitsInStock=0 },
                new Product{ProductId=4, ProductName="Mac Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitsInStock=1 },
                new Product{ProductId=5, ProductName="Dell Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitsInStock=4 }
            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("Product is added with Ado.NET.");
        }

        public Task AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Task<List<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
