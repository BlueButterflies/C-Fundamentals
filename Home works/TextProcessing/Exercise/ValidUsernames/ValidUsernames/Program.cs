using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] user = Console.ReadLine().Split(", ");

            for (int i = 0; i < user.Length; i++)
            {
                string currentUse = user[i];

                bool isValidSymbol = true;
                bool isValidLength = true;

                if (currentUse.Length < 3 || currentUse.Length > 16)
                {
                    isValidLength = false;
                }

                for (int j = 0; j < currentUse.Length; j++)
                {
                    char symbol = currentUse[j];

                    if (!char.IsLetterOrDigit(symbol) && symbol != '-' && symbol != '_')
                    {
                        isValidSymbol = false;
                        break;
                    }
                }
                if (isValidSymbol && isValidLength)
                {
                    Console.WriteLine(currentUse);
                }
            }
        }
    }
}
