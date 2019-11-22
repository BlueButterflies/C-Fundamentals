using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\+359(-| )2\1[0-9]{3}\1[0-9]{4}\b";
            var phones = Console.ReadLine();
            var phoneMatches = Regex.Matches(phones, pattern);
            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
