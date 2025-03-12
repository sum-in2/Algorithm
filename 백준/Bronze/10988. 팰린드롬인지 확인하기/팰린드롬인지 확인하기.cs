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
            string str = sr.ReadLine()!;
            string temp = new string(str.Reverse().ToArray());

            sb.Append(str == temp ? "1" : "0");
            sw.WriteLine(sb.ToString());
        }
    }
}