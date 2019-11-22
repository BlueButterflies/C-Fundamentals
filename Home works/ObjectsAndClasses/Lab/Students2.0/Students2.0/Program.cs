using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;
using System.Text;
using System.Globalization;

namespace Students2._0
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

                if ((StudentExisting(student, firstName, secondName)))
                {
                    Students newStudents = GetStudents(student, firstName, secondName, age);
                }
                else
                {
                    Students students = new Students(firstName, secondName, age, city)
                    {
                        FirstName = firstName,
                        SecondName = secondName,
                        Age = age,
                        City = city
                    };
                    student.Add(students);

                }

                input = Console.ReadLine().Split();
            }
            string town = Console.ReadLine();

            List<Students> studentTown = student.Where(x => x.City == town).ToList();


            foreach (var item in studentTown)
            {
                Console.WriteLine(item);
            }
        }
        static bool StudentExisting(List<Students> student, string firstName, string secondName)
        {
            foreach (var item in student)
            {
                if (item.FirstName == firstName && item.SecondName == secondName)
                {
                    return true;
                }
            }
            return false;
        }
        static Students GetStudents(List<Students> student, string firstName, string secondName, int age)
        {
            Students newStudent = null;

            foreach (var item in student)
            {
                if (item.FirstName == firstName && item.SecondName == secondName)
                {
                    newStudent = item;
                    newStudent.Age = age;
                }
            }
            return newStudent;
        }
    }
}
