using System;

namespace RefAndValueType
{
    public struct ValueType
    {
        public int num;
    }

    public class ReferenceType
    {
        public int num;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //int a = 0;
            //Console.WriteLine($"int before: {a}");
            //ChangeNum(a);
            //Console.WriteLine($"int after: {a}");
            //Console.WriteLine();

            //int[] intArray = new int[] { 1, 2, 3 };
            //Console.WriteLine($"int array before: {intArray[1]}");
            //ChangeNum(intArray);
            //Console.WriteLine($"int array after: {intArray[1]}");
            //Console.WriteLine();

            //string s = "string";
            //Console.WriteLine($"string before: {s}");
            //ChangeStr(s);
            //Console.WriteLine($"string after: {s}");
            //Console.WriteLine();

            //ValueType b = new ValueType();
            //Console.WriteLine($"Value type before: {b.num}");
            //ChangeNum(b);
            //Console.WriteLine($"Value type after: {b.num}");
            //Console.WriteLine();

            //ReferenceType c = new ReferenceType();
            //Console.WriteLine($"Reference type before: {c.num}");
            //ChangeNum(c);
            //Console.WriteLine($"Reference type after: {c.num}");
            //Console.WriteLine();

            Console.Read();
        }

        public static void ChangeStr(string s)
        {
            s = "change";
        }

        public static void ChangeNum(int p)
        {
            p = 1;
        }

        public static void ChangeNum(int[] a)
        {
            a[1] = 9;
        }
        

        public static void ChangeNum(ValueType p)
        {
            p.num = 2;
        }

        public static void ChangeNum(ReferenceType p)
        {
            p.num = 2;
        }
    }
}
