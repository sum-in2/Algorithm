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
                int cnt = int.Parse(sr.ReadLine()!);

                for (int i = 1; i <= cnt; i++)
                {
                    sb.Append("*");
                    sw.WriteLine(sb.ToString());
                }
            }
        }
    }
}