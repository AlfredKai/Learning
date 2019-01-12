using System;
using System.Threading;

namespace GarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "string";
            //while(true)
            //{
            //    //int b = 3;
            //    // string b = "string" + a;
            //}

            //Finalizer
            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    var a = new Destroyer();
                }
                Thread.Sleep(1);
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
        }
    }

    public class Destroyer
    {
        public override string ToString() => GetType().Name;
        ~Destroyer() => Console.WriteLine($"The {ToString()} destructor is executing.");
    }
}
