using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            var net = new Course();
            var photoShop = new Course();
            net.Name = ".Net";
            photoShop.Name = "Photoshop";

            Student[] StudentsFirstCourse = new Student[5]
            {
                new Student("Andrey", net.Name),
                new Student("Ilya", net.Name),
                new Student("Vova", net.Name),
                new Student("Igor", net.Name),
                new Student("Oleg", net.Name)
            };

            Student[] StudentsSecondCourse = new Student[5]
            {
                new Student("Maks", photoShop.Name),
                new Student("Slavik", photoShop.Name),
                new Student("Jhon", photoShop.Name),
                new Student("Doe", photoShop.Name),
                new Student("Wiliam", photoShop.Name)
            };

            net.SetStudents(StudentsFirstCourse);
            photoShop.SetStudents(StudentsSecondCourse);


            net.Teacher = new Teacher("Vasya Petrov", net.Name);
            photoShop.Teacher = new Teacher("Volodya Vasin", photoShop.Name);

            net.Teacher.SetRating(StudentsFirstCourse[0], 5);
            net.Teacher.SetRating(StudentsSecondCourse[0], 5);

            net.PrintStudent();
            net.PrintTeacherName();
            Console.WriteLine("----------");
            net.PrintUspevaimost();
        }
    }
}
