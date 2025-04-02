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
            int N = int.Parse(sr.ReadLine()!) - 1;
            int i = 1;

            for (; N > 0; i++)
            {
                N -= i * 6;
            }
            sb.Append(i);
            sw.WriteLine(sb.ToString());
        }
    }
}
