using System;
using System.Net.Http.Headers;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput())))
            using (StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())))
            {
                int N = int.Parse(sr.ReadLine()!);
                int[] arr = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

                sb.Append($"{arr.Min()} {arr.Max()}");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}