using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalogue
{
    class Car
    {
        public Car(string type, string brand, string model, int horsePower)
        {
            this.Type = type;
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            return $"{this.Brand}: {this.Model} - {this.HorsePower}hp";
        }
    }
}
