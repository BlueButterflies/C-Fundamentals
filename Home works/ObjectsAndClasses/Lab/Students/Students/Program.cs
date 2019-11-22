using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;
using System.Text;
using System.Globalization;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> student = new List<Students>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                string firstName = input[0];
                string secondName = input[1];
                int age = int.Parse(input[2]);
                string city = input[3];

                Students newStudent = new Students(firstName, secondName, age, city);

                student.Add(newStudent);

                input = Console.ReadLine().Split();
            }
            string town = Console.ReadLine();

            List<Students> studentTown = student.Where(x => x.City == town).ToList();


            foreach (var item in studentTown)
            {
                Console.WriteLine($"{item.FirstName} {item.SecondName} is {item.Age} years old.");
            }
        }
    }
}
