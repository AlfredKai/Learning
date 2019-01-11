using System;

namespace GarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //// boxing
            //int a = 1;
            //while(true)
            //{
            //    object b = a;
            //}

            object a = 1;
            // unboxing
            while (true)
            {
                int b = (int)a;
            }
        }
    }
}
