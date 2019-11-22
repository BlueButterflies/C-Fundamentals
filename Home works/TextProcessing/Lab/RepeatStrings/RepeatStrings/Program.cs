using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace _RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            StringBuilder result = new StringBuilder();

            foreach (var texts in text)
            {
                int count = texts.Length;

                for (int i = 0; i < count; i++)
                {
                    result = result.Append(texts);
                }
            }

            Console.WriteLine(result);
        }
    }
}
