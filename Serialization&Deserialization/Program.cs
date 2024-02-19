using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace Serialization_Deserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = "C:\\Users\\a.arabuli\\Desktop";
            //string fileName = "Data.txt";
            //Search(path, fileName, 0);

            // serialization, JSON, XML
            Student student = new Student()
            {
                FirstName = "Giorgi",
                Age = 20,
                LastName = "Giorgadze",
                Id = 1,
                IsMale = true,
                Contact = new Contact() 
                {
                    Home = "3242342",
                    Mobile = "13212312"
                }
            };

            #region Json
            //Student student1 = new Student()
            //{
            //    FirstName = "Giorgi",
            //    Age = 20,
            //    LastName = "Giorgadze",
            //    Id = 1,
            //    IsMale = true,
            //    Contact = new Contact()
            //    {
            //        Home = "3242342",
            //        Mobile = "13212312"
            //    }
            //};
            //Student student2 = new Student()
            //{
            //    FirstName = "Giorgi",
            //    Age = 20,
            //    LastName = "Giorgadze",
            //    Id = 1,
            //    IsMale = true,
            //    Contact = new Contact()
            //    {
            //        Home = "3242342",
            //        Mobile = "13212312"
            //    }
            //};

            //List<Student> students = new List<Student>();
            //students.Add(student);
            //students.Add(student1);
            //students.Add(student2);


            //string jsonStudent = JsonSerializer.Serialize(student);
            //string studentsListInJson = JsonSerializer.Serialize(students);

            //Student deserializedStudent = JsonSerializer.Deserialize<Student>(jsonStudent);
            //var deserializedStudents = JsonSerializer.Deserialize<List<Student>>(studentsListInJson);
            #endregion

            #region XML

            //XmlSerializer serializer = new XmlSerializer(typeof(Student));
            //string xml = string.Empty;
            //using(StringWriter sw = new StringWriter())
            //{
            //    serializer.Serialize(sw, student);
            //    xml = sw.ToString();
            //    Console.WriteLine();
            //}

            //using(StringReader sr = new StringReader(xml)) 
            //{
            //    Student newStudent = (Student)serializer.Deserialize(sr);
            //    Console.WriteLine();
            //}

            #endregion

            #region Binary
            string path = "C:\\Users\\a.arabuli\\Desktop\\Data.bin";
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, student);
            }

            using(FileStream fs = new FileStream(path, FileMode.Open))
            {
                Student student4 = (Student)binaryFormatter.Deserialize(fs);
                Console.WriteLine();
            }

            #endregion
            Console.WriteLine();
        }

        #region DirectorySearcher
        //static void Search(string path, string fileName, int i)
        //{
        //    try
        //    {
        //        DirectoryInfo directory = new DirectoryInfo(path);

        //        foreach (FileInfo file in directory.GetFiles(fileName, SearchOption.TopDirectoryOnly))
        //        {
        //            Console.WriteLine(file.FullName);
        //        }

        //        foreach (var subDir in directory.GetDirectories())
        //        {
        //            Search(subDir.FullName, fileName, i++);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Some error: {ex.Message}");
        //    }
        //}
        #endregion
    }

    [Serializable]
    public class Student
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsMale { get; set; }
        public Contact Contact { get; set; }
    }

    [Serializable]
    public class Contact
    {
        public string Mobile { get; set; }
        public string Home { get; set; }
    }
}