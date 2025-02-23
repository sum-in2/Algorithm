using System;
using System.Net.Http.Headers;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput())))
            using (StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())))
            {
                int cnt = 0;
                int N = int.Parse(sr.ReadLine()!);
                int[] num = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
                int findNumber = int.Parse(sr.ReadLine()!);

                cnt = num.Where(i => i == findNumber).Count();
                sb.AppendLine(cnt.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}