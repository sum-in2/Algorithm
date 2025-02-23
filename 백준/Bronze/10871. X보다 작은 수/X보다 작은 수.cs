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
                int[] result;
                int[] N = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
                int[] num = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

                result = Array.FindAll(num, i => i < N[1]);
                foreach (int i in result)
                    sb.Append($"{i} ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}