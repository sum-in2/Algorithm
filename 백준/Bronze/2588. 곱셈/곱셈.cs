using System.Text;
using static System.Console;

namespace BaekJoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string s1 = ReadLine()!;
            string s2 = ReadLine()!;

            int num1 = int.Parse(s1);

            for (int i = s2.Length - 1; i >= 0; i--)
                sb.AppendLine($"{num1 * int.Parse(s2[i].ToString())}");

            sb.AppendLine($"{num1 * int.Parse(s2)}");

            WriteLine(sb.ToString());
        }
    }
}