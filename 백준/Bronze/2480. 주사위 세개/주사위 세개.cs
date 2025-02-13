using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] dice = Console.ReadLine()!.Split();
            int diceA = int.Parse(dice[0]);
            int diceB = int.Parse(dice[1]);
            int diceC = int.Parse(dice[2]);
            int result;

            if (diceA == diceB && diceB == diceC)
            {
                result = diceA * 1000 + 10000;
            }
            else if (diceA == diceB || diceA == diceC || diceB == diceC)
            {
                result = (diceA == diceB) ? diceA : (diceA == diceC) ? diceA : diceB;
                result = result * 100 + 1000;
            }
            else
            {
                result = Math.Max(diceA, Math.Max(diceB, diceC)) * 100;
            }

            sb.AppendLine($"{result}");
            Console.WriteLine(sb.ToString());
        }
    }
}