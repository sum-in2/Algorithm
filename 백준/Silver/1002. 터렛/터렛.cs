namespace BaekJoon
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!int.TryParse(Console.ReadLine()!, out int tryCount))
                return;

            for (int i = 0; i < tryCount; i++)
            {
                string[] input = Console.ReadLine()!.Split(' ');
                int x1 = int.Parse(input[0]);
                int y1 = int.Parse(input[1]);
                int r1 = int.Parse(input[2]);
                int x2 = int.Parse(input[3]);
                int y2 = int.Parse(input[4]);
                int r2 = int.Parse(input[5]);

                int distSquared = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
                int rSumSquared = (r1 + r2) * (r1 + r2);
                int rDiffSquared = (r1 - r2) * (r1 - r2);

                if (distSquared == 0 && r1 == r2)
                    Console.WriteLine(-1);
                else if (distSquared > rSumSquared || distSquared < rDiffSquared)
                    Console.WriteLine(0);
                else if (distSquared == rSumSquared || distSquared == rDiffSquared)
                    Console.WriteLine(1);
                else
                    Console.WriteLine(2);
            }
        }
    }
}
