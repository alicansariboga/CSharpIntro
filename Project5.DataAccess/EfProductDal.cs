using Microsoft.EntityFrameworkCore;
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
            //_products = new List<Product>
            //{
            //    new Product{ProductId=1, ProductName="Acer ef Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitInStock=2 },
            //    new Product{ProductId=2, ProductName="Asus ef Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitInStock=3 },
            //    new Product{ProductId=3, ProductName="HP ef Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitInStock=0 },
            //    new Product{ProductId=4, ProductName="Mac ef Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitInStock=1 },
            //    new Product{ProductId=5, ProductName="Dell ef Bilgisayar", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitInStock=4 }
            //};
        }
        public void Add(Product product)
        {
            using (ProjectContext projectContext = new ProjectContext())
            {
                projectContext.Products.Add(product);
                projectContext.SaveChanges(); //transaction
            }
        }

        // using yapisi disposable pattern dir. Yani bellekte hizli bir skeilde atilma egilimindedir. Dolayisiyla async yapialrda bunun kullanilmamasi gerekir.
        public async Task AddAsync(Product product)
        {
            ProjectContext projectContext = new ProjectContext();
            await projectContext.Products.AddAsync(product);
            // SaveChanged da default olarak async versiyonu var. Dolayisiyla onda da kullanilmalidir.
            await projectContext.SaveChangesAsync();
        }

        public void Delete(Product product)
        {
            using (ProjectContext projectContext = new ProjectContext())
            {
                //projectContext.Products.Remove(product);
                projectContext.Products.Remove(projectContext.Products.SingleOrDefault(p => p.ProductId == product.ProductId)); // certain process
                projectContext.SaveChanges(); //transaction
            }
        }

        public Task DeleteAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            //ProjectContext projectContext = new ProjectContext();
            //return projectContext.Products.ToList();
            // NOTE: Normally, after this block is executed, the garbageCollector collects the projectContext object and goes away. To prevent this from happening, using method is used here.

            using (ProjectContext projectContext = new ProjectContext())
            {
                return projectContext.Products.ToList();
            }
            //dispose = throw away from memory fastly
        }

        public Task<List<Product>> GetAllAsync()
        {
            ProjectContext projectContext = new ProjectContext();
            return projectContext.Products.ToListAsync();
        }

        public Product GetById(int id)
        {
            using (ProjectContext projectContext = new ProjectContext())
            {
                return projectContext.Products.SingleOrDefault(p => p.ProductId == id);
                // SingleOrDefault == for only 1 data
                // FirstOrDefault() == If there is more than one data that meets this condition; Returns the first given data.

            }
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            using (ProjectContext projectContext = new ProjectContext())
            {
                var productToUpdate = projectContext.Products.SingleOrDefault(p => p.ProductId == product.ProductId); // not updated data
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.CategoryId = product.CategoryId;


                projectContext.SaveChanges(); // updated finished and saved.
            }
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
