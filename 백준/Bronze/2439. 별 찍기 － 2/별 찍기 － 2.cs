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
                int cnt = int.Parse(sr.ReadLine()!);

                for (int i = 0; i < cnt; i++)
                {
                    for (int j = cnt - i; j > 1; j--)
                        sb.Append(" ");
                    for (int j = 0; j < i + 1; j++)
                        sb.Append("*");
                    sb.Append("\n");
                }

                sw.WriteLine(sb.ToString());
            }
        }
    }
}