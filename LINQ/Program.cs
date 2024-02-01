using System.Collections;
using System.Linq.Expressions;
using System.Threading.Channels;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ(Language integrated query)  
            // Lint to objects(collections (list,array,stack))
            // Linq to database(relationa databases)
            // Linq to xml

            //string[] names = { "gia", "nina", "tekla", "giorgi", "demetre" };

            //// query syntax

            //var query = from name in names
            //            where name.Contains("a")
            //            select name;

            // amovigot masividan srulwlovani studentebi queris wyalobit

            Student[] students =
            {
                new Student(){ StudentId = 1, StudentName = "Giorgi", Age = 18 },
                new Student(){ StudentId = 2, StudentName = "nana", Age = 19 },
                new Student(){ StudentId = 3, StudentName = "Qeti", Age = 16 },
                new Student(){ StudentId = 4, StudentName = "Giorgi", Age = 14 },
                new Student(){ StudentId = 5, StudentName = "Giorgi", Age = 13 }
            };

            //FindStudent findStudent = delegate (Student student)
            //{
            //    return student.Age > 18;
            //};

            //FindStudent teenAgers = delegate (Student student)
            //{
            //    return student.Age >= 13 && student.Age <= 18;
            //};

            //Student[] fitleredStudents = StudentExtension.Where(students, findStudent);
            //Student[] fitleredStudents1 = StudentExtension.Where(students, teenAgers);

            //var teenAgerStudents = students.Where(s => s.Age > 12 && s.Age < 18).ToArray();
            //var qeti = students.Where(s => s.StudentName == "Qeti").ToArray();
            //var student5 = students.Where(s => s.StudentId == 5).ToArray();
            
            // Query syntax

            IList<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };
            //var result = from @string in stringList
            //             where @string.Contains("Tutorials")
            //             select @string;
            var result = stringList.Where(s => s.Contains("Tutorials"));

            var res = () => Console.WriteLine("Hello");
            res.Invoke();
        }
    }

    delegate bool FindStudent(Student student);
    static class StudentExtension
    {
        public static Student[] Where(Student[] studentArray, FindStudent del)
        {
            int i = 0;
            Student[] students = new Student[5];
            foreach (var item in studentArray)
            {
                if (del(item))
                {
                    students[i] = item;
                    i++;
                }
            }
            return students;
        }
    }

    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}