using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @">>(?<name>.+)<<(?<price>[0-9]+\.?[0-9]*)!(?<quantity>[0-9]+)";

            string input = Console.ReadLine();

            List<string> furniture = new List<string>();
            decimal totalSpendMoney = 0;

            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furniture.Add(name);
                    totalSpendMoney += price * quantity;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");

            foreach (var furnitures in furniture)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furnitures));
            }
            Console.WriteLine($"Total money spend: {totalSpendMoney:f2}");
        }
    }
}
