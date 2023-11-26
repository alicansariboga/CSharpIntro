using Project5.DataAccess;
using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.Business
{
    public class ProductManager
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            //ProductDal productDal = new ProductDal();

            // business codes

            return _productDal.GetAll();
        }
    }
}
