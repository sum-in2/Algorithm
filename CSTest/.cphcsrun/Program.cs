using System.Text;

namespace BaekJoon;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        string[] s = Console.ReadLine()!.Split();

        if (long.TryParse(s[0], out long valueA) &&
        long.TryParse(s[1], out long valueB) &&
        long.TryParse(s[2], out long valueC))
        {
            sb.AppendLine($"{valueA + valueB + valueC}");
        }

        Console.WriteLine(sb);
    }
}
