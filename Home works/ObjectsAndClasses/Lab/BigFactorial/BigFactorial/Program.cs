using System;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;
using System.Text;
using System.Globalization;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 2; i <= numbers; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
