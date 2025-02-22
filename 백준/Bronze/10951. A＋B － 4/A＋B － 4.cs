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

                while (true)
                {
                    string str = sr.ReadLine()!;
                    if (str == null)
                        break;

                    sb.AppendLine($"{Array.ConvertAll(str.Split(), int.Parse).Sum()}");
                }

                sw.WriteLine(sb.ToString());
            }
        }
    }
}