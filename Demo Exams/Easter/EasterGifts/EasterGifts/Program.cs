using System;
using System.Linq;
using System.Collections.Generic;

namespace EasterGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gifts = Console.ReadLine().Split().ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "No Money")
                {
                    break;
                }
                string[] commands = command.Split().ToArray();

                if (commands[0] == "OutOfStock")
                {
                    if (commands.Count() == 2)
                    {
                        for (int i = 0; i < gifts.Count; i++)
                        {

                            if (gifts[i].Contains(commands[1]))
                            {
                                int index = gifts.IndexOf(commands[1]);
                                string outOfStockGift = commands[1];
                                gifts.Remove(commands[1]);
                                gifts.Insert(index, "None");
                            }
                        }
                    }
                }
                else if (commands[0] == "Required")
                {
                    if (commands.Count() == 3)
                    {
                        string gift = commands[1];
                        int index = int.Parse(commands[2]);
                        if (index >= 0 && index < gifts.Count)
                        {
                            gifts.RemoveAt(index);
                            gifts.Insert(index, gift);
                        }
                    }
                }
                else if (commands[0] == "JustInCase")
                {
                    if (commands.Count() == 2)
                    {
                        int indexOfLastGift = gifts.Count - 1;
                        gifts.RemoveAt(indexOfLastGift);
                        gifts.Add(commands[1]);
                    }
                }
            }
            if (gifts.Contains("None"))
            {
                gifts.RemoveAll(gift => gift == "None");
            }
            Console.WriteLine(string.Join(" ", gifts));

        }
    }
}
