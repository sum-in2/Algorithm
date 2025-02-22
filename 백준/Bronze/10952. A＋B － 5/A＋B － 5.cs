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
                int temp;
                while ((temp = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse).Sum()) != 0)
                {
                    sb.AppendLine(temp.ToString());
                }

                sw.WriteLine(sb.ToString());
            }
        }
    }
}