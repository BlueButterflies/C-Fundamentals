using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"([\w-.]+@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";

            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var result = match.ToString();

                if (!(result.StartsWith("-") || result.StartsWith(".") || result.StartsWith("_")
                    || result.EndsWith("-") || result.EndsWith(".") || result.EndsWith("_")))
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
