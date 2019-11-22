using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int explosion = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (explosion > 0 && input[i] != '>')
                {
                    input = input.Remove(i, 1);

                    explosion--;
                    i--;   
                }
                else if (input[i] == '>')
                {
                    explosion += int.Parse(input[i + 1].ToString());
                }
            }
            Console.WriteLine(input);
        }
    }
}
