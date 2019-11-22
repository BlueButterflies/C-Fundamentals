using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string letters = "";
            string number = "";
            string symbol = "";

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if(char.IsLetter(ch))
                {
                    letters += ch;
                }
                else if(char.IsNumber(ch))
                {
                    number += ch;
                }
                else if(char.IsPunctuation(ch) || char.IsSymbol(ch))
                {
                    symbol += ch;
                }
            }
            Console.WriteLine(number + Environment.NewLine + letters + Environment.NewLine + symbol);
            
        }
    }
}
