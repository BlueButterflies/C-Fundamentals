using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string articleTitle = Console.ReadLine();
            string contentOfTitle = Console.ReadLine();

            string comments = Console.ReadLine();

            List<string> comment = new List<string>();

            while (comments != "end of comments")
            {
                if (comments == "end of comments")
                {
                    return;
                }
                else
                {
                    comment.Add(comments);
                }
                comments = Console.ReadLine();
            }

            Console.WriteLine("<h1>" + Environment.NewLine + $"    {articleTitle} " + Environment.NewLine + "</h1>");
            Console.WriteLine("<article>" + Environment.NewLine + $"    {contentOfTitle}" + Environment.NewLine + "</article>");

            foreach (var item in comment)
            {
                Console.WriteLine("<div>" + Environment.NewLine + $"    {item}" + Environment.NewLine + "</div>");
            }
        }
    }
}
