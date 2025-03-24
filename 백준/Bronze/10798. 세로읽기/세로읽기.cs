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
            string[] input = new string[5];

            for (int i = 0; i < 5; i++)
            {
                input[i] = sr.ReadLine()!;
            }

            int maxIndex = input.Select(x => x.Length).Max();
            for (int i = 0; i < maxIndex; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (input[j].Length > i)
                        sb.Append(input[j][i]);
                }
            }
            sw.Write(sb.ToString());
        }
    }
}
