using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int gugu = int.Parse(Console.ReadLine()!);

            for (int i = 1; i < 10; i++)
            {
                sb.AppendLine($"{gugu} * {i} = {gugu * i}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}