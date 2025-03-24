using System;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
        {
            int max = -1;
            int[] maxIndex = new int[2];

            for (int i = 0; i < 9; i++)
            {
                foreach (var item in Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse).Select((value, index) => (value, index)))
                {
                    var index = item.index;
                    var value = item.value;

                    if (value > max)
                    {
                        max = value;
                        maxIndex[0] = i + 1;
                        maxIndex[1] = index + 1;
                    }
                }
            }

            sb.AppendLine($"{max}");
            sb.Append($"{maxIndex[0]} {maxIndex[1]}");

            sw.Write(sb.ToString());
        }
    }
}
