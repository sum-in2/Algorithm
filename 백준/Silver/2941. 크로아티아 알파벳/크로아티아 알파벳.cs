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
            string[] alphabet = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
            string str = sr.ReadLine()!;

            foreach (string temp in alphabet)
            {
                string originalString = str;
                str = str.Replace(temp, " ");
            }

            sb.Append(str.Length.ToString());
            sw.WriteLine(sb.ToString());
        }
    }
}