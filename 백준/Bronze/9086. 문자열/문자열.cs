using System;
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

                for (int i = 0; i < N; i++)
                {
                    string input = sr.ReadLine()!;
                    sb.AppendLine($"{input[0]}{input[^1]}");
                }
                sw.WriteLine(sb.ToString());
            }
        }
    }
}