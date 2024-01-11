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
            Console.WriteLine();
        }
    }
}