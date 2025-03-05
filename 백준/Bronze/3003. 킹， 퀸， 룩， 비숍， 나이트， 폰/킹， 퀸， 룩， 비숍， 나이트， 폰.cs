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
            int[] chessBase = new int[] { 1, 1, 2, 2, 2, 8 };
            int[] input = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            chessBase = chessBase.Zip(input, (a, b) => a - b).ToArray();

            sb.Append(String.Join(" ", chessBase));
            sw.WriteLine(sb.ToString());
        }
    }
}