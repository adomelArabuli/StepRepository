using System.Threading.Channels;

namespace Delegates
{
    public delegate void MyDelelate(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            // Signature (Delegate references a method with the same signature)
            //MyDelelate myDelelate1 = new MyDelelate(DisplayMessage);
            //myDelelate1("Hello I am deligate");

            //MyDelelate myDelelate2 = new MyDelelate(ShowUpperCase);
            //myDelelate2("upper case");

            //MyDelelate combinedDelegate = myDelelate1 + myDelelate2;

            //combinedDelegate("We are combined delegates");

            //combinedDelegate -= ShowUpperCase;
            //combinedDelegate -= DisplayMessage;

            //combinedDelegate("after removing one method");

            //Calculator calculator = new Calculator();
            //CallBackDelegate callBackDelegate = new CallBackDelegate(DisplayResult);
            //calculator.Add(10, 13, callBackDelegate);


            //List<int> ints = new(){ 1,10,-5,12,22,-6,33,-7};

            //CheckDelegate evenCheck = new CheckDelegate(PredicatDeligate.IsEven);
            //CheckDelegate positiveCheck = new CheckDelegate(PredicatDeligate.IsPositive);

            //List<int> evenNumbers = FilterList(ints, evenCheck);
            //List<int> positiveNumbers = FilterList(ints, positiveCheck);

            //Console.WriteLine();

            //Calculator calculator = new Calculator();

            //OperationDelegate addDelegate = delegate (int x, int y)
            //{
            //    Console.WriteLine($"the sum is: {x + y}");
            //};
            //addDelegate(1, 2);

            //// => 
            //OperationDelegate subtractDelegate = (x, y) =>
            //{
            //    Console.WriteLine($"the substaction is: {x - y}");
            //};

            //calculator.PerformOperation(10, 5, addDelegate);
            //calculator.PerformOperation(10, 5, subtractDelegate);

            // func, action

            Func<int, int, string> mimateba = (a, b) => (a + b).ToString();
            Console.WriteLine(mimateba(10,20));

            Action<string> prinMessage = message => Console.WriteLine(message);
            prinMessage("Hello");

            // predicate 

            List<int> numbers = new List<int>() { 1,2,3,4,10,20};
            Predicate<int> isEven = x => x % 2 == 0;

            Predicate<int> greaterThanFive = x => x > 5;

            List<int> evenNums = numbers.FindAll(isEven);
            Console.WriteLine();

            int[] numbersGreaterThanFive = Array.FindAll(numbers.ToArray(), greaterThanFive);

        }

        static List<int> FilterList(List<int> list, CheckDelegate checkDelegate)
        {
            List<int> result = new List<int>();

            foreach (int i in list)
            {
                if (checkDelegate(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static void DisplayResult(int result)
        {
            Console.WriteLine($"Result {result}");
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        public static void ShowUpperCase(string message)
        {
            Console.WriteLine($"Upper case: {message.ToUpper()}");
        }
    }
}