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
                int N = int.Parse(sr.ReadLine()!);
                int[] num = new int[N];

                string str = sr.ReadLine()!;
                num = str.Select(c => (int)Char.GetNumericValue(c)).ToArray();

                sb.AppendLine(num.Sum().ToString());
                sw.WriteLine(sb.ToString());
            }
        }
    }
}