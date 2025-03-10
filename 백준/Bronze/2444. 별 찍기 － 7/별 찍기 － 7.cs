using System;
using System.Text;

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
                for (int j = N - 1; j > 0; j--)
                    sb.Append(j <= i ? "*" : " ");
                sb.Append("*");
                for (int j = 0; j < N - 1; j++)
                    sb.Append(j < i ? "*" : "");
                sb.AppendLine();
            }
            for (int i = 1; i < N; i++)
            {
                for (int j = 0; j < N - 1; j++)
                    sb.Append(j >= i ? "*" : " ");
                sb.Append("*");
                for (int j = N - 1; j > 0; j--)
                    sb.Append(j > i ? "*" : "");
                sb.AppendLine();
            }
            sw.WriteLine(sb.ToString());
        }
    }
}