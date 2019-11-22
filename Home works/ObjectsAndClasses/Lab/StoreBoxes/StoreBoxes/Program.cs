using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;
using System.Text;
using System.Globalization;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {

            List<StoreBoxes> storeBoxes = new List<StoreBoxes>();

            decimal sumOfBox = 0;

            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                int serialNumber = int.Parse(input[0]);
                string name = input[1];
                int quantity = int.Parse(input[2]);
                decimal price = decimal.Parse(input[3]);

                sumOfBox = quantity * price;

                StoreBoxes box = new StoreBoxes(serialNumber, name, quantity, price, sumOfBox);

                box.SumOfBox = quantity * price;

                storeBoxes.Add(box);

                input = Console.ReadLine().Split();
            }

            List<StoreBoxes> sortedSum = storeBoxes.OrderByDescending(x => x.SumOfBox).ToList();

            foreach (var item in sortedSum)
            {
                Console.WriteLine(item);
            }
        }
    }
    }
}
