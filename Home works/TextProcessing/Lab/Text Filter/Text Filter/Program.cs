using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordSpecial = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var words in wordSpecial)
            {
                if(text.Contains(words))
                {
                    text = text.Replace(words, new string('*', words.Length));

                }
            }
            Console.WriteLine(text);
        }
    }
}
