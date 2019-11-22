using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            var healtPattern = @"[^0-9+\-*\/.]";
            Regex healtRegex = new Regex(healtPattern);

            var digitPattern = @"-?\d+\.?\d*";
            Regex digitRegex = new Regex(digitPattern);

            var operatorPattern = @"[*\/]";
            Regex operatorRegex = new Regex(operatorPattern);

            string[] denomName = Regex.Split(Console.ReadLine(), @"\s*,\s*")
                .OrderBy(n => n)
                .ToArray();

            for (int i = 0; i < denomName.Length; i++)
            {
                string currentDemonName = denomName[i];

                int currentHealt = 0;

                MatchCollection healtSymbol = healtRegex.Matches(currentDemonName);

                foreach (Match symbol in healtSymbol)
                {
                    currentHealt += char.Parse(symbol.Value);
                }

                MatchCollection digitSymbol = digitRegex.Matches(currentDemonName);

                double demonDigit = 0;

                foreach (Match digitDemon in digitSymbol)
                {
                    demonDigit += double.Parse(digitDemon.Value);
                }

                MatchCollection operatorSymbol = operatorRegex.Matches(currentDemonName);

                foreach (Match operatorDemon in operatorSymbol)
                {
                    var operatorr = operatorDemon.Value;

                    if(operatorr == "*")
                    {
                        demonDigit *= 2;
                    }
                    else
                    {
                        demonDigit /= 2;
                    }
                }
                Console.WriteLine($"{currentDemonName} - {currentHealt} health, {demonDigit:f2} damage");
            }
        }
    }
}
