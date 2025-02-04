using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] s = Console.ReadLine()!.Split();
            int a = int.Parse(s[0]);

            if ((a % 4 == 0 && a % 100 != 0) || (a % 400 == 0))
                sb.AppendLine("1");
            else
                sb.AppendLine("0");

            Console.WriteLine(sb.ToString());
        }
    }
}