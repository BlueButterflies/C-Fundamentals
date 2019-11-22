using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            MatchCollection matchesName = Regex.Matches(input, pattern);

            foreach (Match item in matchesName)
            {
               Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
