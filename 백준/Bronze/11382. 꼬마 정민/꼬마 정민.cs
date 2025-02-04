namespace BaekJoon;

class Program
{
    static void Main(string[] args)
    {
        long result = 0;
        string[] s = Console.ReadLine()!.Split();

        if (long.TryParse(s[0], out long valueA) &&
        long.TryParse(s[1], out long valueB) &&
        long.TryParse(s[2], out long valueC))
        {
            result = valueA + valueB + valueC;
        }

        Console.WriteLine(result);
    }
}
