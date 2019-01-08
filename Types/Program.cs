using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueType a = new ValueType();
            Console.WriteLine($"Value type before: {a.num}");
            ChangeNum(a);
            Console.WriteLine($"Value type after: {a.num}");
            Console.WriteLine();

            ReferenceType b = new ReferenceType();
            Console.WriteLine($"Value type before: {b.num}");
            ChangeNum(b);
            Console.WriteLine($"Value type after: {b.num}");
            Console.WriteLine();

            ValueType c = new ValueType();
            Console.WriteLine($"Value type before: {c.num}");
            ChangeNum(ref c);
            Console.WriteLine($"Value type after: {c.num}");
            Console.WriteLine();

            ReferenceType d = new ReferenceType();
            Console.WriteLine($"Value type before: {d.num}");
            ChangeNum(ref d);
            Console.WriteLine($"Value type after: {d.num}");
            Console.WriteLine();

            int[] refInt = new int[] { 1, 2, 3 };
            Console.WriteLine($"Value type before: {refInt[1]}");
            ChangeNum(ref refInt);
            Console.WriteLine($"Value type after: {refInt[1]}");

            Console.Read();
        }

        public static void ChangeNum(int[] a)
        {
            a[1] = 9;
        }

        public static void ChangeNum(ref int[] a)
        {
            a[1] = 9;
        }

        public static void ChangeNum(ValueType p)
        {
            p.num = 2;
        }

        public static void ChangeNum(ref ValueType p)
        {
            p.num = 2;
        }

        public static void ChangeNum(ReferenceType p)
        {
            var g = new ReferenceType();
            g.num = 2;
            p = g;
        }

        public static void ChangeNum(ref ReferenceType p)
        {
            var g = new ReferenceType();
            g.num = 2;
            p = g;
        }
    }

    public struct ValueType
    {
        public int num;
    }

    public class ReferenceType
    {
        public int num;
    }
}
