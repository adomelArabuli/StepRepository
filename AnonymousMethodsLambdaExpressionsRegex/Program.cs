using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace AnonymousMethodsLambdaExpressionsRegex
{
    internal class Program
    {
        public delegate void MyDeligate(string message);
        static void Main(string[] args)
        {

            // anonymous methods
            // lambda expression

            //MyDeligate myDeligate = delegate(string message)
            //{
            //    Console.WriteLine($"Message is: {message}");
            //    Console.WriteLine("test");
            //    Console.WriteLine("test1");
            //};
            //myDeligate("Hello");


            //MyDeligate myDeligate1 = message => Console.WriteLine($"Lambda expression {message}");

            //// Action, Func

            //Func<int,int,int,int> add = (a,b,c) => a + b + c;
            //Console.WriteLine(add(10, 20, 40));

            //Action<int,int> action = (a,b) => Console.WriteLine(a + b);
            //action(2, 4);

            #region RegularExpression

            // pattern

            string emailPattern = @"^[a-zA-Z0-9._%+-!/]+@[a-zA-Z0-9.\-!]+\.[a-zA-Z]{2,}$";

            string passwordPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*()\\-=_+{}[\\]:;<>,.?/~\\\\])\\S{8,}$";

            string userEmail = "";
            string userPass = "Tbilisi1";

            Regex regex = new Regex(passwordPattern);

            if (regex.IsMatch(userPass))
            {
                Console.WriteLine("valid pass");
            }
            else
            {
                Console.WriteLine("invalid pass");
            }
            // test123!@gmail.com
            // Quantifiers : +

            #endregion
        }
    }
}