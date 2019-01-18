using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    public class P
    {
        public Action<string> Print = (s) => Console.WriteLine(s);

        public event Action<string> OnCreate;
        public void InvokeEvent()
        {
            if (OnCreate != null)
                OnCreate("This is event!");
        }
    }

    class Program
    {
        public delegate void PrintConsole(string s);
        static PrintConsole a = Print;
        static Action<string> b = Print;

        public delegate int PerformCalculation(int x, int y);
        static PerformCalculation c = Add;
        static Func<int, int, int> d = Add;

        static void Main(string[] args)
        {
            //a("this is invoke");
            //Print("this is method");

            //// lambda
            //Action<string> action = s => Console.WriteLine(s);
            //action("this is lambda");

            //// lambda
            //List<int> list = new List<int>();
            //for (int i = 1; i <= 100; i++)
            //    list.Add(i);

            //List<int> result = list.FindAll(i =>  i % 2 == 0);

            //foreach (var item in result)
            //    Console.WriteLine(item);

            //// replace delegate
            //P a = new P();
            //a.Print("invoke");
            //a.Print = (s) => Console.WriteLine("hello");
            //a.Print("invoke");

            //// Event
            //P a = new P();
            //a.OnCreate += (s) => Console.WriteLine(s);
            //a.OnCreate += (s) => Console.WriteLine(s);
            //a.InvokeEvent();

            Console.Read();
        }

        public static void Print(string s)
        {
            Console.WriteLine(s);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
