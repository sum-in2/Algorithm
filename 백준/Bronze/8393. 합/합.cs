using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int cnt = int.Parse(Console.ReadLine()!);
            int result = 0;

            for (int i = 1; i <= cnt; i++)
            {
                result += i;
            }

            sb.AppendLine($"{result}");
            Console.WriteLine(sb.ToString());
        }
    }
}