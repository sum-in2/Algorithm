using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int totalMoney = int.Parse(Console.ReadLine()!);
            int n = int.Parse(Console.ReadLine()!);
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                result += int.Parse(input[0]) * int.Parse(input[1]);
            }

            sb.Append(result == totalMoney ? "Yes" : "No");
            Console.WriteLine(sb.ToString());
        }
    }
}