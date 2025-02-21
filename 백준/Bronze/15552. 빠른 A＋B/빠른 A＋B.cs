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

            for (int i = 0; i < cnt; i++)
            {
                sb.AppendLine($"{Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse).Sum()}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}