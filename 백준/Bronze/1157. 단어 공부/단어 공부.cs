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
            int[] alphabet = new int[26];
            int maxValue;

            foreach (char c in str)
            {
                int index = (int)c;
                alphabet[index >= 'a' ? index - 'a' : index - 'A']++;
            }

            maxValue = alphabet.Max();

            int[] maxValueIndexList =
                alphabet.Select((value, index) => new { value = value, index = index })
                .Where(x => x.value == maxValue)
                .Select(x => x.index)
                .ToArray();

            if (maxValueIndexList.Length > 1)
                sb.Append("?");
            else
                sb.Append((char)(maxValueIndexList[0] + 'A'));

            sw.WriteLine(sb.ToString());
        }
    }
}