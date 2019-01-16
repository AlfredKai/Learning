using System;
using System.IO;

namespace Generic
{
    public interface Parsible<T>
    {
        T Parse(string line);
    }

    public class Tree : Parsible<Tree>
    {
        public string a;
        public string b;
        public string c;
        public string d;

        public Tree Parse(string line)
        {
            var s = line.Split(',');
            a = s[0];
            b = s[1];
            c = s[2];
            d = s[3];
            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var parser = new Parser<Tree>("Tree.txt");
            var trees = parser.Parse();
            foreach(var t in trees)
                Console.WriteLine($"a:{t.a},b:{t.b},c:{t.c},d:{t.d}");
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
