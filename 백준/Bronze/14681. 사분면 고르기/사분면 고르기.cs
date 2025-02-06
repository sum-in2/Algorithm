using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int x = int.Parse(Console.ReadLine()!);
            int y = int.Parse(Console.ReadLine()!);
            int result = 0;
            if (x > 0 && y > 0)
                result = 1;
            else if (x < 0 && y > 0)
                result = 2;
            else if (x < 0 && y < 0)
                result = 3;
            else if (x > 0 && y < 0)
                result = 4;

            sb.AppendLine($"{result}");
            Console.WriteLine(sb.ToString());
        }
    }
}