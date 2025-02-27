using System;
using System.Text;
using System.Xml.XPath;

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
                int N = int.Parse(sr.ReadLine()!);
                int[] score = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
                int highScore = score.Max();
                float result = 0f;

                for (int i = 0; i < N; i++)
                    result += (score[i] / (float)highScore) * 100;

                sb.Append(result / N);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}