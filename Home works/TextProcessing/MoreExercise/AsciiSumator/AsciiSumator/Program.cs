using System;

namespace AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();


            int startIndex = Math.Min(firstSymbol, secondSymbol);
            int endIndex = Math.Max(firstSymbol, secondSymbol);

            int sumSymbol = 0;

            for (int i = 0; i < text.Length; i++)
            {
                int currentSymbol = text[i];

                if(currentSymbol > startIndex && currentSymbol < endIndex)
                {
                    sumSymbol += currentSymbol;
                }
            }
            Console.WriteLine(sumSymbol);
        }
    }
}
