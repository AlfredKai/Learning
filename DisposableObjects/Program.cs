using System.IO;

namespace DisposableObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file = new StreamWriter("test.txt");
            file.WriteLine("Bridgewell");
            file.Dispose();

            //using (StreamWriter file = new StreamWriter("test.txt"))
            //{
            //    file.WriteLine("Bridgewell");
            //}
        }
    }
}
