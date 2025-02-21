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

            for (int i = 0; i < cnt / 4; i++)
            {
                sb.Append("long ");
            }
            sb.AppendLine("int");

            Console.WriteLine(sb.ToString());
        }
    }
}