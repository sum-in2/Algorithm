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
                string input = sr.ReadLine()!;
                int i = int.Parse(sr.ReadLine()!);

                sb.Append(input[i - 1]);
                sw.WriteLine(sb.ToString());
            }
        }
    }
}