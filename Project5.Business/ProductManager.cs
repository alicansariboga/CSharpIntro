using Project5.DataAccess;
using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.Business
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            //basic
            if (product.ProductName == "Laptop")
            {
                throw new DublicateProductException("You can not add this product.");
            }
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            //ProductDal productDal = new ProductDal();

            // business codes

            return _productDal.GetAll();
        }

        public Task<List<Product>> GetAllAsync()
        {
            return _productDal.GetAllAsync();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
