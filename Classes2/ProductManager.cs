using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    //Methods -- ProductManager -- ProductService kavramlari
    //reusability - OOP
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Urun Sisteme Eklendi : " + product.ProductName);
        }
    }
}
