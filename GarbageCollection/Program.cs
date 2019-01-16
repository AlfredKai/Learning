using System;
using System.Threading;

namespace GarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "string";
            while (true)
            {
                //int a = 3;
                //int[] a = new int[10];
                //string a = "bridgewell is very well";
                //string a = "string" + s;
            }

            ////Boxing
            //int a = 1;
            //while(true)
            //{
            //    object b = a;
            //}

            ////Unboxing
            //object a = 1;
            //while (true)
            //{
            //    int b = (int)a;
            //}

            //Finalizer
            //while (true)
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        var a = new Destroyer();
            //    }
            //    Thread.Sleep(1);
            //}
        }
    }

    public class Destroyer
    {
        public override string ToString() => GetType().Name;
        ~Destroyer() => Console.WriteLine($"The {ToString()} destructor is executing.");
    }
}
