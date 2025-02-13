using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] time = Console.ReadLine()!.Split();
            int hour = int.Parse(time[0]);
            int minute = int.Parse(time[1]);

            int total = (hour * 60 + minute - 45 + 1440) % 1440;
            hour = total / 60;
            minute = total % 60;


            sb.AppendLine($"{hour} {minute}");
            Console.WriteLine(sb.ToString());
        }
    }
}