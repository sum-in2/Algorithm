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

            if (int.TryParse(s[0], out int a) && int.TryParse(s[1], out int b))
            {
                sb.AppendLine(a == b ? "==" : (a > b ? ">" : "<"));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}