using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Students
    {
        public Students(string firstName, string secondName, int age, string city)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
            this.City = city;
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
