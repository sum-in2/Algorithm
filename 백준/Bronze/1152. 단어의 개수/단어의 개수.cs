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
                string[] S = sr.ReadLine()!.Split(' ');
                S = S.Where(str => !string.IsNullOrWhiteSpace(str)).ToArray();
                sb.Append(S.Length);
                sw.WriteLine(sb.ToString());
            }
        }
    }
}