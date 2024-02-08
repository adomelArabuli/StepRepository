using System.Collections;

namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "gia", "nina", "tekla", "giorgi", "demetre" };

            //var result = names.Where(s => s.Contains("i"));

            //var filteredStudetns = from student in studentList
            //                       where student.Age > 12 && student.Age < 20
            //                       select student.StudentName;

            //var filteredStudetns = studentList.Where(x => x.Age > 12 && x.Age < 20);
            //var filteredStudetns = studentList.Where((s,i) =>
            //{
            //    if(i % 2 == 0)return true;
            //    return false;
            //});

            //var filteredStudetns = from s in studentList
            //                       where s.Age > 12
            //                       where s.Age < 20
            //                       select s;

            var mixedList = new ArrayList()
            {
                'c',
                "string",
                "string1",
                65,
                654,
                true,
                false
            };

            var stringList = from s in mixedList.OfType<string>()
                             select s;
            var boolList = from s in mixedList.OfType<bool>()
                             select s;

            //var orderedByNameAsc = from s in studentList
            //                    orderby s.StudentName
            //                    select s;

            //var orderedByNameDesc = from s in studentList
            //                    orderby s.StudentName
            //                    orderby s.Age
            //                    select s;                 ?

            //var orderedByNameAsc = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);
            //var orderedByNameDesc = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);

            //IsYougerThan isYougerThan =  (s, minAge) => s.Age < minAge; // ar mushaobs

            //Print print = () => 
            //{
            //    Console.WriteLine("test");
            //    Console.WriteLine("skjadhajs");
            //};
            //var teenagerStudents = studentList.Where(s => s.Age >= 13 && s.Age <= 17);

            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 13 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 20 } ,
            new Student() { StudentID = 4, StudentName = "John" , Age = 20} ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            //var groupedStudents = from student in studentList
            //                      group student by student.Age;
            //var groupedStudents = studentList.GroupBy(s => s.Age); // Can not mutate
            var groupedStudents = studentList.ToLookup(s => s.Age); // Can mutate

            

            foreach (var studentGroup in groupedStudents)
            {
                Console.WriteLine($"Age Group {studentGroup.Key}");
                foreach (var item in studentGroup)
                {
                    Console.WriteLine($"Student name {item.StudentName}");
                }
            }

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var test = numbers.ToLookup(n => n % 2 == 0 ? "Even" : "Odd");
        }

        delegate void Print();
        delegate bool IsYougerThan(Student student, int minAge);

    }

    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public int AllowedHeartRate()
        {
            return (220 - Age) * 70/100;
        }
    }
}