using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string firstWord = words[0];
            string secondWord = words[1];

            string minLengthWord = "";
            string maxLengthWord = "";

            if(firstWord.Length > secondWord.Length)
            {
                minLengthWord = secondWord;
                maxLengthWord = firstWord;
            }
            else
            {
                minLengthWord = firstWord;
                maxLengthWord = secondWord;
            }

            int totalSum = 0;

            for (int i = 0; i < minLengthWord.Length; i++)
            {
                totalSum += minLengthWord[i] * maxLengthWord[i];
            }

            for (int i = minLengthWord.Length; i < maxLengthWord.Length; i++)
            {
                totalSum += maxLengthWord[i];
            }

            Console.WriteLine(totalSum);
        }
    }
}
