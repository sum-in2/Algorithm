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
            int N = int.Parse(sr.ReadLine()!);
            int cnt = 0;
            int diagonal = 0;
            int different;

            while (cnt < N)
            {
                diagonal++;
                cnt += diagonal;
            }

            different = cnt - N;

            if (diagonal % 2 == 0)
                sb.AppendLine($"{diagonal - different}/{different + 1}");
            else
                sb.AppendLine($"{different + 1}/{diagonal - different}");


            sw.WriteLine(sb.ToString());
        }
    }
}
