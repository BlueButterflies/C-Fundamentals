using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalogue
{
    class Truck
    {
        public Truck(string type, string brand, string model, int weight)
        {
            this.Type = type;
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }

        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"{this.Brand}: {this.Model} - {this.Weight}kg";
        }
    }
}
