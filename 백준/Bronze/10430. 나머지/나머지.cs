using System.Text;
using static System.Console;

namespace BaekJoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string[] s = Console.ReadLine()!.Split();
            if (int.TryParse(s[0], out int a) &&
                int.TryParse(s[1], out int b) &&
                int.TryParse(s[2], out int c))
            {
                sb.AppendLine($"{(a + b) % c}");
                sb.AppendLine($"{((a % c) + (b % c)) % c}");
                sb.AppendLine($"{(a * b) % c}");
                sb.AppendLine($"{((a % c) * (b % c)) % c}");
                WriteLine(sb.ToString());
            }
        }
    }
}