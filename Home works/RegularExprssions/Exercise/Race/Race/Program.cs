using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> nameDistance = new Dictionary<string, double>();
            var patternLetters = new Regex(@"(?<name>[A-Za-z])");
            var patternDigit = new Regex(@"(?<distance>[0-9])");
            
            List<string> input = Console.ReadLine().Split(", ").ToList();

            string text = Console.ReadLine();

            while (text != "end of race")
            {
                var name = patternLetters.Matches(text);
                var distance = patternDigit.Matches(text);

                StringBuilder namee = new StringBuilder();
                var totalDictance = 0;

                foreach (Match item in name)
                {
                    namee.Append(item.Value);
                }
                foreach (Match kvp in distance)
                {
                    totalDictance += int.Parse(kvp.Value);
                }

                if (input.Contains(namee.ToString()))
                {
                    if (nameDistance.ContainsKey(namee.ToString()))
                    {
                        nameDistance[namee.ToString()] += totalDictance;
                    }
                    else
                    {
                        nameDistance.Add(namee.ToString(), totalDictance);
                    }
                }
                text = Console.ReadLine();
            }
            nameDistance = nameDistance.OrderByDescending(d => d.Value).Take(3).ToDictionary(n => n.Key, d => d.Value);

            List<string> namesWiner = new List<string>();

            foreach (var item in nameDistance.OrderByDescending(d => d.Value))
            {
                namesWiner.Add(item.Key);
            }
            Console.WriteLine($"1st place: {namesWiner[0]}");
            Console.WriteLine($"2nd place: {namesWiner[1]}");
            Console.WriteLine($"3rd place: {namesWiner[2]}");

        }
    }
}
