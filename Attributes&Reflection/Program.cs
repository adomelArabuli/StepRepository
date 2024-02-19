using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Attributes_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person person = new Person();
            Console.WriteLine(person.Name);
            // attribute 
            // Reflection
            // Assembly
            Type type = typeof(Person);

            MethodInfo[] methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }

            PropertyInfo[] properties = type.GetProperties();   
        }
    }

    [Serializable]
    class Person
    {
        public void Method1()
        {
            Console.WriteLine();
        }
        [Required]
        public string Name { get; set; }

        [Required] public string Address { get; set; }
        public int Age { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password")]
        public string RepeatPassword { get; set; }


        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}