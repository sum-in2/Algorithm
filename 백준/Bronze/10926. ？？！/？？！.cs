using System.Text;

namespace BaekJoon;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();

        string s = Console.ReadLine();
        sb.AppendLine($"{s}??!");

        Console.WriteLine(sb.ToString());
    }
}
