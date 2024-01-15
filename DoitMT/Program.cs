using System.Diagnostics.Contracts;
using System.Reflection;
using System.Text;
using System.Threading.Channels;

namespace DoitMT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dispose
            using (FileStream fs = new FileStream("example.txt", FileMode.Create))
            {
                Console.WriteLine("test");
            }

            Person person = new Person();
            person.Name = "Gia";

            person.Dispose();

            Console.WriteLine();
        }

        class Person : IDisposable
        {
            public string Name { get; set; }

            public void Dispose()
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.SuppressFinalize(this);
            }
        }
    }
}