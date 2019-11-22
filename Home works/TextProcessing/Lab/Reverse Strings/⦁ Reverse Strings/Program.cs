using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace __Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();

            while (word != "end")
            {
                var reversedString = word.ToArray().Reverse();

                Console.WriteLine($"{word} = {string.Join("", reversedString)}");

                word = Console.ReadLine();
            }
        }
    }
}
