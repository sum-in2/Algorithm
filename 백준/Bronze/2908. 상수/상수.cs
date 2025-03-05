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
            string[] input = sr.ReadLine()!.Split(' ');
            int[] num = input.Select(x => int.Parse(new string(x.Reverse().ToArray()))).ToArray();

            sb.Append(num.Max());
            sw.WriteLine(sb.ToString());
        }
    }
}