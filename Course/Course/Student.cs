using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Student
    {
        public string Name {get; set; }
        public string NameOfCourse { get; set; }
        public int Rating { get; set; }

        public Student(string name, string nameOfCourse)
        {
            Name = name;
            NameOfCourse = nameOfCourse;
        }


    }
}
