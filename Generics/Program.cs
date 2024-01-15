using BenchmarkDotNet.Running;
using System.Collections;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Comment
            // კოდის დუბლირებას თავიდან ვიცილებთ (მემკვიდრეობითობის და ჯენერიკების წყალობით).
            // Generics - გადავიკითხოთ
            // Swap

            //int a = 1;
            //int b = 2;

            //int c = 1;
            //int d = 2;

            //Swap(ref c, ref d);

            //Console.WriteLine($"a:{a} \tb:{b}");

            //Swap(ref a,ref  b );

            //Console.WriteLine($"a:{a} \tb:{b}");

            //string c = "Hello";
            //string d = "World";

            //Console.WriteLine($"c:{c} \td:{d}");

            //Swap(ref c,ref d);

            //Console.WriteLine($"c:{c} \td:{d}");

            //bool b1 = true;
            //bool b2 = false;

            //Swap(ref b1, ref b2);

            //Console.WriteLine(b1);
            //Console.WriteLine(b2);

            #endregion

            //var list = new MyList<string>();
            //list.Add("Hello");
            //list.Add("World");

            //Console.WriteLine(list[0]);
            //Console.WriteLine(list[1]);

            //BenchmarkRunner.Run(typeof(Program).Assembly); // პირველი ვარიანტი
            //BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);// მეორე ვარიანტი ბენჩმარკის გაშვების

            // dagvrcha - nested ტიპები Generic კლასის შიგნით; Generic ინტერფეისების შექმნა;

            GenericMethods gm = new GenericMethods();
            Console.WriteLine(gm.FindMaximum(100, 1000));
            Console.WriteLine(gm.FindMaximum("Hello","World1"));

        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        //static void Swap(ref int x, ref int y )
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //static void Swap(ref string a, ref string b)
        //{
        //    string temp = a;
        //    a = b;
        //    b = temp;
        //}

    }
}