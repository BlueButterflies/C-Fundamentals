using System;
using System.Collections.Generic;
using System.Linq;

namespace LastStop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] currentCommand = command.Split().ToArray();

                if (currentCommand[0] == "Insert")
                {
                    if (int.Parse(currentCommand[1]) > -1 && int.Parse(currentCommand[1]) < numbers.Count)
                    {
                        numbers.Insert(int.Parse(currentCommand[1]) + 1, int.Parse(currentCommand[2]));
                    }
                }
                else if (currentCommand[0] == "Hide")
                {
                    if (numbers.Contains(int.Parse(currentCommand[1])))
                    {
                        numbers.Remove(int.Parse(currentCommand[1]));
                    }
                }
                else if (currentCommand[0] == "Switch")
                {
                    if (numbers.Contains(int.Parse(currentCommand[1])))
                    {
                        int firstPaiting = int.Parse(currentCommand[1]);
                        int secondPaiting = int.Parse(currentCommand[2]);

                        if (numbers.Contains(firstPaiting) && numbers.Contains(secondPaiting))
                        {
                            SwitchPaintings(numbers, firstPaiting, secondPaiting);
                        }
                    }
                }
                else if (currentCommand[0] == "Change")
                {
                    int oldPaiting = int.Parse(currentCommand[1]);
                    int newPaiting = int.Parse(currentCommand[2]);
                    if (numbers.Contains(oldPaiting))
                    {
                        Change(numbers, oldPaiting, newPaiting);
                    }
                }
                else if (currentCommand[0] == "Reverse")
                {
                    numbers.Reverse();
                }
                command = Console.ReadLine();
            }
            //command = Console.ReadLine();

            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
        }

        private static void Change(List<int> numbers, int oldPaiting, int newPaiting)
        {
            int index = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == oldPaiting)
                {
                    index = i;
                }
            }
            numbers.Insert(index, newPaiting);
            numbers.Remove(oldPaiting);

        }

        private static void SwitchPaintings(List<int> numbers, int firstPiting, int secondPaiting)
        {
            int firstIndex = 0;
            int secondIndex = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == firstPiting)
                {
                    firstIndex = i;
                }
                if (numbers[i] == secondPaiting)
                {
                    secondIndex = i;
                }

            }
            numbers.Insert(secondIndex + 1, firstPiting);
            numbers.RemoveAt(secondIndex);
            numbers.Insert(firstIndex + 1, secondPaiting);
            numbers.RemoveAt(firstIndex);
        }
    }
}
