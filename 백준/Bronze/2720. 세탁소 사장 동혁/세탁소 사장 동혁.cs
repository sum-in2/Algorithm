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
            int T = int.Parse(sr.ReadLine()!);
            int[] coins = { 25, 10, 5, 1 };

            for (int i = 0; i < T; i++)
            {
                int C = int.Parse(sr.ReadLine()!);

                foreach (int coin in coins)
                {
                    sb.Append($"{C / coin} ");
                    C %= coin;
                }
                sb.AppendLine();
            }

            sw.WriteLine(sb.ToString());
        }
    }
}
