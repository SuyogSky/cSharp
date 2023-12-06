using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Student
    {
        private String name;
        private int age;
        private String major;

        public Student(String name, int age, String major)
        {
            this.name = name;
            this.age = age;
            this.major = major;
        }

        public void Introduce()
        {
            Console.WriteLine($"Student name : {name}\nStudent age : {age}\nStudent major : {major}");
        }
    }
}
