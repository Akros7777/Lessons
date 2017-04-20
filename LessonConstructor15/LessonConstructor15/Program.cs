using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonConstructor15
{
    class Student
    {
        public string name;
        public UInt16 course;
        public bool scholarship;

        public Student(string studentName, UInt16 studentCourse) : this(studentName, studentCourse, false) { }
        public Student(string studentName, UInt16 studentCourse, bool studentScholarship)
        {
            this.name = studentName;
            this.course = studentCourse;
            this.scholarship = studentScholarship;
        }

        public void increaseCourse()
        {
            this.course += 1;
        }

        public void PrintStudent()
        {
            Console.WriteLine("Name " + name + " Course " + course + " scholarship " + scholarship);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student studentIvan = new Student("Ivan", 4);
            Student studentAnton = new Student("Anton", 2, true);
            Student studentDenis = new Student("Denis", 2, false);

            List <Student> listStudents = new List<Student>() { studentIvan, studentAnton, studentDenis };
            listStudents.ForEach(tempStudent => { tempStudent.PrintStudent(); });

        }
    }
}
