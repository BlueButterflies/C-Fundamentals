using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractPersonInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string text = Console.ReadLine();

                string name = text.Substring(text.IndexOf("@") + 1, text.IndexOf("|") - text.IndexOf("@") - 1);
                int age = int.Parse(text.Substring(text.IndexOf("#") + 1, text.IndexOf("*") - text.IndexOf("#") - 1));

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
