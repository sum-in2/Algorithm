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
            string str = input[0];
            int B = int.Parse(input[1]);

            long result = 0;
            foreach (char c in str)
            {
                int digitValue;
                if (char.IsDigit(c))
                {
                    digitValue = c - '0';
                }
                else
                {
                    digitValue = c - 'A' + 10;
                }
                result = result * B + digitValue;
            }

            sb.Append(result);
            sw.WriteLine(sb.ToString());
        }
    }
}
