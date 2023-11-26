using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            //Console.WriteLine(product.Id);
            product.UnitsInStock = 50;
            Console.WriteLine(product.UnitsInStock);
            product.UnitPrice = 500;
            Console.WriteLine(product.UnitPrice);

        }
    }
    class Product
    {
        // get=read, set=write

        decimal _unitPrice; //field
        int _id = 1;
        public int Id { set { _id = value; } } //writeonly
        public string Name { get; } //readonly
        public string Status { get; set; }
        public decimal UnitPrice { 
            get { return _unitPrice + _unitPrice * 18 / 100; } 
            set { _unitPrice = value; }
        }
        public decimal UnitsInStock;//default => get and set
        // with this syntax cant't do that which happened process about UnitPrice.
    }
}
