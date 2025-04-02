using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
        {
            int side = 2;
            int N = int.Parse(sr.ReadLine()!);

            for (int i = 0; i < N; i++)
                side += side - 1;

            sb.AppendLine($"{Math.Pow(side, 2)}");
            sw.WriteLine(sb.ToString());
        }
    }
}
