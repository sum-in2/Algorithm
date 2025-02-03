namespace BaekJoon;

class Program
{
    static void Main(string[] args)
    {
        double result = 0;
        string[] s = Console.ReadLine().Split();

        if (double.TryParse(s[0], out double valueA) && double.TryParse(s[1], out double valueB))
        {
            result = valueA / valueB;
        }

        Console.WriteLine(result);
    }
}
