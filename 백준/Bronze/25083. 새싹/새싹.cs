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
            string[] str = {
                "         ,r'\"7",
                "r`-_   ,'  ,/",
                " \\. \". L_r'",
                "   `~\\/",
                "      |",
                "      |"
            };
            foreach (string output in str)
                sb.AppendLine(output);
            sw.WriteLine(sb.ToString());
        }
    }
}