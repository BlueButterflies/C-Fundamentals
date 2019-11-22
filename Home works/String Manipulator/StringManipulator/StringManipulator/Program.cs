using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] splitedInput = input.Split();
                string command = splitedInput[0];

                switch (command)
                {
                    case "Add":
                        text += splitedInput[1];
                        break;
                    case "Upgrade":
                        var symbol = (char)(splitedInput[1][0] + 1);

                        text = text.Replace(splitedInput[1][0], symbol);
                        break;
                    case "Print":
                        Console.WriteLine(text);
                        break;
                    case "Index":
                        char index = char.Parse(splitedInput[1]);

                        if (!text.Contains(index.ToString()))
                        {
                            Console.WriteLine("None");
                        }
                        else
                        {
                            for (int i = 0; i < text.Length; i++)
                            {
                                if (text[i] == index)
                                {
                                    Console.Write(i + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "Remove":
                        string stringToRemove = splitedInput[1];
                        var sb2 = new StringBuilder();
                        sb2 = sb2.Append(text);
                        sb2 = sb2.Replace(stringToRemove, "");
                        text = sb2.ToString();
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
