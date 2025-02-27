using System;
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
                int[] input = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
                int[] num = new int[input[0]];

                for (int i = 0; i < input[0]; i++)
                    num[i] = i + 1;

                for (int i = 0; i < input[1]; i++)
                {
                    int[] index = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
                    Array.Reverse(num, index[0] - 1, index[1] - index[0] + 1);
                }

                foreach (int i in num)
                    sb.Append($"{i} ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}