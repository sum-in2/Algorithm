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

            if (a >= 90)
                sb.AppendLine("A");
            else if (a >= 80)
                sb.AppendLine("B");
            else if (a >= 70)
                sb.AppendLine("C");
            else if (a >= 60)
                sb.AppendLine("D");
            else
                sb.AppendLine("F");

            Console.WriteLine(sb.ToString());
        }
    }
}