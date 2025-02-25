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
                int[] num = new int[30];
                for (int i = 0; i < 28; i++)
                {
                    int index = int.Parse(sr.ReadLine()!) - 1;
                    num[index] = 1;
                }

                for (int i = 0; i < 30; i++)
                {
                    if (num[i] == 0)
                        sb.AppendLine($"{i + 1}");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}