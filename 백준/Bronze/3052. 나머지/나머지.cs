using System;
using System.ComponentModel;
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
                HashSet<int> result = new HashSet<int>();

                for (int i = 0; i < 10; i++)
                {
                    result.Add(int.Parse(sr.ReadLine()!) % 42);
                }

                sb.Append(result.Count());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}