using System;
using System.Linq;


namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToList();

            var random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                var randomIndex = random.Next(0, words.Count);

                var randomElements = words[randomIndex];

                var element = words[i];

                words[randomIndex] = element;
                words[i] = randomElements;
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
