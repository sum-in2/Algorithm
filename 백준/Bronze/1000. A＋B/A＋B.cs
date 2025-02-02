namespace BaekJoon;

class Program
{
    static void Main(string[] args)
    {
        int result = 0;
        string[] s = Console.ReadLine().Split();

        foreach (string num in s)
        {
            if (int.TryParse(num, out int Value))
            {
                result += Value;
            }
        }

        Console.WriteLine(result);
    }
}
