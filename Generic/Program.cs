using System;
using System.IO;
using System.Collections.Generic;

namespace Generic
{
    public interface Parsible<T>
    {
        T Parse(string line);
    }

    public class Record : Parsible<Record>
    {
        public string a;
        public string b;
        public string c;

        public Record Parse(string line)
        {
            var s = line.Split(',');
            a = s[0];
            b = s[1];
            c = s[2];
            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //List<int> listA = new List<int>() { 1, 2, 3, 4 };
            //List<string> listB = new List<string>() { "a", "b", "c" };

            ////Customize Generic Class
            //var parser = new Parser<Record>("Records.txt");
            //var records = parser.Parse((line) =>
            //{
            //    var s = line.Split(',');
            //    Record r = new Record() { a = s[0], b = s[1], c = s[2] };
            //    return r;
            //});
            //foreach (var record in records)
            //    Console.WriteLine($"{nameof(record.a)}:{record.a},{nameof(record.b)}:{record.b},{nameof(record.c)}:{record.c}");

            //// Customize Generic Class
            //var parser = new Parser<Record>("Records.txt");
            //var records = parser.Parse();
            //foreach (var record in records)
            //    Console.WriteLine($"{nameof(record.a)}:{record.a},{nameof(record.b)}:{record.b},{nameof(record.c)}:{record.c}");

            Console.Read();
        }
    }

    public class Parser<T> where T : Parsible<T>, new()
    {
        string filename = string.Empty;

        public Parser(string fname)
        {
            filename = fname;
        }

        public T[] Parse(Func<string, T> parse)
        {
            var lines = File.ReadAllLines(filename);
            T[] result = new T[lines.Length];
            int count = 0;
            foreach (var line in lines)
            {
                result[count] = parse(line);
                count++;
            }
            return result;
        }

        public T[] Parse()
        {
            var lines = File.ReadAllLines(filename);
            T[] result = new T[lines.Length];
            int count = 0;
            foreach(var line in lines)
            {
                var typeParser = new T();
                result[count] = typeParser.Parse(line);
                count++;
            }
            return result;
        }
    }
}
