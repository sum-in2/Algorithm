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
                int T = int.Parse(sr.ReadLine()!);

                for (int i = 0; i < T; i++)
                {
                    string[] S = sr.ReadLine()!.Split();
                    int R = int.Parse(S[0]);

                    sb.AppendLine(String.Concat(S[1].Select(c => new string(c, R))));
                }

                sw.WriteLine(sb.ToString());
            }
        }
    }
}