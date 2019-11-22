using System;
using System.Linq;
using System.Numerics;
using System.Globalization;
using System.Collections.Generic;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };


            int countMesseges = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < countMesseges; i++)
            {
                string phrase = phrases[random.Next(0, phrases.Length)];
                string @event = phrases[random.Next(0, events.Length)];
                string author = phrases[random.Next(0, authors.Length)];
                string city = phrases[random.Next(0, cities.Length)];

                Console.WriteLine($"{phrase}{@event}{author}{city}.");
            }


        }
    }
}
