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
            int num = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            while (num > 0)
            {
                int remainder = num % B;
                char digit = remainder > 9 ? (char)(remainder + 55) : (char)(remainder + '0');

                sb.Insert(0, digit);
                num /= B;
            }
            sw.WriteLine(sb.ToString());
        }
    }
}
