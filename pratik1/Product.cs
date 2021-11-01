using System;
using System.Collections.Generic;
using System.Text;

namespace pratik1
{
    class Product
    { 
        public Product (int id, string name, string brand, int quantity, double price)
        {   this.Id = id;
            this.Name = name;
            this.Brand = brand;
            this.Quantity = quantity;
            this.Price = price;
    
        }
    
        public int Id;
        public string Name;
        public string Brand;
        public int Quantity;
        public double Price;
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Brand: {Brand}, Quantity: {Quantity}, Price: {Price}";

        }

    }
}
