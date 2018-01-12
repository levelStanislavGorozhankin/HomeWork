using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Course
    {
        public Teacher Teacher { get; set; }

        public string Name { get; set; }

        private Student[] Students { get; set; }

        public void SetStudents(Student[] students)
        {
            if (students.Length > 5) return;
            Students = students;
        }

        public void PrintStudent()
        {
            for (var i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(Students[i].Name);
            }
        }

        public void PrintTeacherName()
        {
            Console.WriteLine(Teacher.Name);
        }

        public void PrintUspevaimost()
        {
            for (var i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(Students[i].Name +" " + Students[i].Rating);
            }
        }

    }
}
