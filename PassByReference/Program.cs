using System;

namespace PassByReference
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
            int a = 0;
            Console.WriteLine($"int before: {a}");
            ChangeNum(ref a);
            Console.WriteLine($"int after: {a}");
            Console.WriteLine();

            ValueType c = new ValueType();
            Console.WriteLine($"Value type with 'ref' keyword before: {c.num}");
            ChangeNum(ref c);
            Console.WriteLine($"Value type with 'ref' keyword after: {c.num}");
            Console.WriteLine();

            ReferenceType d = new ReferenceType();
            Console.WriteLine($"Reference type 'ref' keyword before: {d.num}");
            ChangeNum(ref d);
            Console.WriteLine($"Reference type 'ref' keyword after: {d.num}");
            Console.WriteLine();
        }
        public static void ChangeNum(ref int p)
        {
            p = 1;
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
}
