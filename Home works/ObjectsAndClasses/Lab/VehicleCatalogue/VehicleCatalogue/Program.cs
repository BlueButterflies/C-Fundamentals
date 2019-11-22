using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;
using System.Text;
using System.Globalization;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new Catalog();

            catalog.Cars = new List<Car>();
            catalog.Trucks = new List<Truck>();

            string[] input = Console.ReadLine().Split("/");

            while (input[0] != "end")
            {
                if (input[0] == "Car")
                {
                    string type = input[0];
                    string brand = input[1];
                    string model = input[2];
                    int horsePower = int.Parse(input[3]);

                    Car cars = new Car(type, brand, model, horsePower);

                    catalog.Cars.Add(cars);
                }
                else if (input[0] == "Truck")
                {
                    string type = input[0];
                    string brand = input[1];
                    string model = input[2];
                    int weight = int.Parse(input[3]);

                    Truck truck = new Truck(type, brand, model, weight);

                    catalog.Trucks.Add(truck);
                }
                input = Console.ReadLine().Split("/");
            }

            if (catalog.Cars.Count > 0)
            {
                List<Car> orderCarByBrand = catalog.Cars.OrderBy(x => x.Brand).ToList();

                Console.WriteLine("Cars:");

                foreach (var item in orderCarByBrand)
                {
                    Console.WriteLine(item);
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                List<Truck> orderTruckByBrand = catalog.Trucks.OrderBy(x => x.Brand).ToList();

                Console.WriteLine("Trucks:");

                foreach (var truck in orderTruckByBrand)
                {
                    Console.WriteLine(truck);
                }
            }
        }
    }
}
