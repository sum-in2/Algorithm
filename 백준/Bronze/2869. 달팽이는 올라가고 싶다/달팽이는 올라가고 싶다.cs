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
            string[] input = sr.ReadLine()!.Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int V = int.Parse(input[2]);

            int days = (V - B + (A - B - 1)) / (A - B);

            sb.Append(days);
            sw.WriteLine(sb.ToString());
        }
    }
}
