using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBoxes
{
    class StoreBoxes
    {
        public StoreBoxes(int seriamNumber, string name, int quantity, decimal price, decimal sumOfBox)
        {
            this.SerialNumber = seriamNumber;
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
            this.SumOfBox = sumOfBox;
        }
        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SumOfBox { get; set; }

        public override string ToString()
        {
            return $"{this.SerialNumber}" + Environment.NewLine
                + $"-- {this.Name} - ${this.Price:f2}: {this.Quantity}"
                + Environment.NewLine
                + $"-- ${this.SumOfBox:f2}";
        }
    }
}
