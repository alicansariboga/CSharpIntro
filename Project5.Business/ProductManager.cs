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

        public List<Product> GetAll()
        {
            //ProductDal productDal = new ProductDal();

            // business codes

            return _productDal.GetAll();
        }
    }
}
