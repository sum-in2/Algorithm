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
            int N = int.Parse(sr.ReadLine()!);
            int groupWord = 0;

            for (int i = 0; i < N; i++)
            {
                string inputString = sr.ReadLine()!;
                List<char> groupList = new List<char>();
                char lastChar = inputString[0];
                groupList.Add(inputString[0]);

                for (int j = 1; j < inputString.Length; j++)
                {
                    if (lastChar != inputString[j])
                    {
                        groupList.Add(inputString[j]);
                    }
                    lastChar = inputString[j];
                }

                if (groupList.Count == groupList.Distinct().Count())
                    groupWord++;
            }
            sb.Append(groupWord);
            sw.WriteLine(sb.ToString());
        }
    }
}