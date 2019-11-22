using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string LettersAndNumbers = input[i];

                char firstLetter = LettersAndNumbers[0];
                char lastLetter = LettersAndNumbers[LettersAndNumbers.Length - 1];
                double number = double.Parse(LettersAndNumbers.Substring(1, LettersAndNumbers.Length - 2));

                if(char.IsLower(firstLetter))
                {                          //'a'
                    number *= firstLetter - 97 + 1;
                }
                else
                {                          //'A'
                    number /= firstLetter - 65 + 1;
                }

                if(char.IsLower(lastLetter))
                {                         //'a'
                    number += lastLetter - 97 + 1;
                }
                else
                {                          //'A'
                    number -= lastLetter - 65 + 1;
                }

                result += number;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
