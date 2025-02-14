using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int cnt = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < cnt; i++)
            {
                string[] nums = Console.ReadLine()!.Split();
                int num1 = int.Parse(nums[0]);
                int num2 = int.Parse(nums[1]);

                sb.AppendLine($"{num1 + num2}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}