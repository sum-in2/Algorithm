using System;
using System.ComponentModel;
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
                string[] str = sr.ReadLine()!.Split();
                int N = int.Parse(str[0]);
                int M = int.Parse(str[1]);

                int[] result = new int[N];
                for (int i = 0; i < N; i++)
                    result[i] = i + 1;

                for (int i = 0; i < M; i++)
                {
                    int[] num = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
                    (result[num[0] - 1], result[num[1] - 1]) = (result[num[1] - 1], result[num[0] - 1]);
                }
                
                foreach (int i in result)
                    sb.Append($"{i} ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}