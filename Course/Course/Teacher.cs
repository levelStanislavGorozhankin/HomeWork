using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Teacher
    {
        public string Name { get; set; }
        public string NameOfCourse { get; set; }

    public Teacher(string name, string nameOfCourse)
        {
            Name = name;
            NameOfCourse = nameOfCourse;
        }

        public void SetRating(Student student, int rating)
        {
            if (student.NameOfCourse == NameOfCourse)
                student.Rating = rating;
            else Console.WriteLine("Нельзя поставить оценку студенту другого курса");
        }
    }
}
