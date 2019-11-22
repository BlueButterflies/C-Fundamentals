using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string output = Regex.Replace(text, "(.)\\1+", "$1");
            Console.WriteLine(output);
        }
    }
}
