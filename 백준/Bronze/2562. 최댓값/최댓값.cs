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
                int[] arr = new int[9];
                int maxNumIndex;
                for (int i = 0; i < 9; i++)
                    arr[i] = int.Parse(sr.ReadLine()!);

                maxNumIndex = Array.IndexOf(arr, arr.Max());
                sb.AppendLine(arr[maxNumIndex].ToString());
                sb.AppendLine((maxNumIndex + 1).ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}