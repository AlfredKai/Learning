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
            Console.WriteLine($"int with 'ref' before: {a}");
            ChangeNum(ref a);
            Console.WriteLine($"int with 'ref' after: {a}");
            Console.WriteLine();

            ValueType b = new ValueType();
            Console.WriteLine($"Value type with 'ref' before: {b.num}");
            ChangeNum(ref b);
            Console.WriteLine($"Value type with 'ref' after: {b.num}");
            Console.WriteLine();

            ReferenceType c = new ReferenceType();
            Console.WriteLine($"Reference type before: {c.num}");
            ChangeNum(c);
            Console.WriteLine($"Reference type after: {c.num}");
            Console.WriteLine();

            ReferenceType d = new ReferenceType();
            Console.WriteLine($"Reference type 'ref' before: {d.num}");
            ChangeNum(ref d);
            Console.WriteLine($"Reference type 'ref' after: {d.num}");
            Console.WriteLine();

            Console.Read();
        }
        public static void ChangeNum(ref int p)
        {
            p = 1;
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
            var t = new ReferenceType();
            t.num = 2;
            p = t;
        }

        public static void ChangeNum(ref ReferenceType p)
        {
            var t = new ReferenceType();
            t.num = 2;
            p = t;
        }
    }
}
