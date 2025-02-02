namespace BaekJoon;

class Program
{
    static void Main(string[] args)
    {
        int result = 0;
        string[] s = Console.ReadLine().Split();

        if (int.TryParse(s[0], out int valueA) && int.TryParse(s[1], out int valueB))
        {
            result = valueA - valueB;
        }

        Console.WriteLine(result);
    }
}
