using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] morseCode = Console.ReadLine().Split(" ");

            List<string> textFromCode = new List<string>();

            for (int i = 0; i < morseCode.Length; i++)
            {
                string code = morseCode[i];

                switch (code)
                {
                    case ".-":
                        textFromCode.Add("a");
                        break;
                    case "-...":
                        textFromCode.Add("b");
                        break;
                    case "-.-.":
                        textFromCode.Add("c");
                        break;
                    case "-..":
                        textFromCode.Add("d");
                        break;
                    case ".":
                        textFromCode.Add("e");
                        break;
                    case "..-.":
                        textFromCode.Add("f");
                        break;
                    case "--.":
                        textFromCode.Add("g");
                        break;
                    case "....":
                        textFromCode.Add("h");
                        break;
                    case "..":
                        textFromCode.Add("i");
                        break;
                    case ".---":
                        textFromCode.Add("j");
                        break;
                    case "-.-":
                        textFromCode.Add("k");
                        break;
                    case ".-..":
                        textFromCode.Add("l");
                        break;
                    case "--":
                        textFromCode.Add("m");
                        break;
                    case "-.":
                        textFromCode.Add("n");
                        break;
                    case "---":
                        textFromCode.Add("o");
                        break;
                    case ".--.":
                        textFromCode.Add("p");
                        break;
                    case "--.-":
                        textFromCode.Add("q");
                        break;
                    case ".-.":
                        textFromCode.Add("r");
                        break;
                    case "...":
                        textFromCode.Add("s");
                        break;
                    case "-":
                        textFromCode.Add("t");
                        break;
                    case "..-":
                        textFromCode.Add("u");
                        break;
                    case "...-":
                        textFromCode.Add("v");
                        break;
                    case ".--":
                        textFromCode.Add("w");
                        break;
                    case "-..-":
                        textFromCode.Add("x");
                        break;
                    case "-.--":
                        textFromCode.Add("y");
                        break;
                    case "--..":
                        textFromCode.Add("z");
                        break;
                    case "|":
                        textFromCode.Add(" ");
                        break;
                }
            }

            var result = string.Empty;

            foreach (var item in textFromCode)
            {
                result += item.ToString().ToUpper();
            }

            Console.WriteLine(result);
        }
    }
}
