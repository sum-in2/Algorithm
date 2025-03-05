using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        using (StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput())))
        using (StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())))
        {
            string str;
            while ((str = sr.ReadLine() ?? "") != "")
            {
                sb.AppendLine(str);
            }
            sw.WriteLine(sb.ToString());
        }
    }
}