using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmojiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var emojiCode = Console.ReadLine().Split(":");

            var power = 0;
            var emojiList = new List<string>();

            var pattern = @"(?<=[\s])(?<emoji>:[a-z]{4,}:)(?=[\s,.!?])";
            if (Regex.IsMatch(input, pattern))
            {
                var matche = Regex.Matches(input, pattern);
                foreach (Match match in matche)
                {
                    var emoji = match.Groups["emoji"].Value;
                    emojiList.Add(emoji);
                    for (int i = 1; i < emoji.Length - 1; i++)
                    {
                        power += emoji[i];
                    }
                }
            }

            var givenEmoji = string.Empty;

            for (int i = 0; i < emojiCode.Length; i++)
            {
                var symbol = (char)(int.Parse(emojiCode[i]));
                givenEmoji += symbol;
            }

            for (int i = 0; i < emojiList.Count; i++)
            {
                var currentEmoji = emojiList[i].Remove(0, 1);

                currentEmoji = currentEmoji.Remove(currentEmoji.Length - 1, 1);

                if (currentEmoji == givenEmoji)
                {
                    power *= 2;
                    break;
                }
            }

            if (emojiList.Count > 0)
            {
                Console.WriteLine($"Emojis found: {string.Join(", ", emojiList)}");
            }

            Console.WriteLine($"Total Emoji Power: {power}");
        }
    }
}
