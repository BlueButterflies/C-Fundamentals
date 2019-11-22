using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = Console.ReadLine().Split('\\');

            string fileArr = file[file.Length - 1];

            string fileName = fileArr.Substring(0, fileArr.LastIndexOf('.'));
            string fileExtension = fileArr.Substring(fileArr.LastIndexOf('.') + 1);

            Console.WriteLine($"File name: {fileName}" + Environment.NewLine + $"File extension: {fileExtension}");
        }
    }
}
