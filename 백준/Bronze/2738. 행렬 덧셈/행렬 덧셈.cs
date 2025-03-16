using System;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
        {
            int[] input = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
            int n = input[0];
            int m = input[1];

            int[,] result = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                int[] row = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
                for (int j = 0; j < m; j++)
                {
                    result[i, j] = row[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                int[] row = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
                for (int j = 0; j < m; j++)
                {
                    result[i, j] += row[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sb.Append(result[i, j]);
                    if (j < m - 1) sb.Append(' ');
                }
                sb.AppendLine();
            }

            sw.Write(sb.ToString());
        }
    }
}
