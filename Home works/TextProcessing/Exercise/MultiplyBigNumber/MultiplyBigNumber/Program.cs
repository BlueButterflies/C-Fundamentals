using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart('0');
            int multiplierNumber = int.Parse(Console.ReadLine());

            if (multiplierNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int reminder = 0;

            StringBuilder builder = new StringBuilder();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currentDigit = number[i] - '0';

                int result = (currentDigit * multiplierNumber) + reminder;

                builder.Append(result % 10);

                reminder = result / 10;
            }

            if (reminder > 0)
            {
                builder.Append(reminder);
            }

            Console.WriteLine(string.Join("",builder.ToString().Reverse()));
        } 
    }
}
