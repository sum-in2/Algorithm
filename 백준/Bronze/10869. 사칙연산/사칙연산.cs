using System.Text;

namespace BaekJoon;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        string[] s = Console.ReadLine().Split();

        if (int.TryParse(s[0], out int valueA) && int.TryParse(s[1], out int valueB))
        {
            sb.AppendLine($"{valueA + valueB}");
            sb.AppendLine($"{valueA - valueB}");
            sb.AppendLine($"{valueA * valueB}");
            sb.AppendLine($"{valueA / valueB}");
            sb.AppendLine($"{valueA % valueB}");
        }

        Console.WriteLine(sb.ToString());
    }
}
