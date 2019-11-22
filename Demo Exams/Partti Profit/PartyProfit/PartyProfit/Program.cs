using System;
using System.Linq;
using System.Collections.Generic;

namespace PartyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int companions = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());


            double coins = 50 * day;

            for (int i = 1; i <= day; i++)
            {

                if (i % 10 == 0)
                {
                    companions -= 2;
                }
                if (i % 15 == 0)
                {
                    companions += 5;
                }
                if (i % 3 == 0)
                {
                    coins -= companions * 3;
                }
                if (i % 5 == 0)
                {
                    coins += 20 * companions;

                    if (i % 3 == 0)
                    {
                        coins -= companions * 2;
                    }
                }
                coins -= companions * 2;
            }
            double totalCoins = Math.Floor(coins / companions);
            Console.WriteLine($"{companions} companions received {totalCoins} coins each.");
        }
    }
}
