using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int shift = 3;

            string result = EncryptedText(text,shift);

            Console.WriteLine(result);
        }
        static public string EncryptedText(string text, int shift)
        {
            string message = null;

            for (int i = 0; i < text.Length; i++)
            {
                int ASCII = (int)text[i];
                message += (char)(ASCII + shift);
            }

            return message;
        }
    }
}
