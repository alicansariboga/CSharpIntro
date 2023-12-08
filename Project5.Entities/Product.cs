using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.Entities
{
    public class Product : IEntity
    {
        public int ProductId { get; set; } // primary key
        public int CategoryId { get; set; } // foreign key
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; } // error for type of int.
    }
}
