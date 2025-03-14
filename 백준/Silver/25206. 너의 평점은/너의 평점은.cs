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
            double totalCredit = 0;
            double totalGrade = 0;

            Dictionary<string, double> creditMap = new Dictionary<string, double>
            {
                {"F", 0.0},
                {"A+", 4.5},
                {"B+", 3.5},
                {"C+", 2.5},
                {"D+", 1.5},
                {"A0", 4.0},
                {"B0", 3.0},
                {"C0", 2.0},
                {"D0", 1.0}
            };

            for (int i = 0; i < 20; i++)
            {
                string[] input = sr.ReadLine()!.Split();

                if (creditMap.ContainsKey(input[2]))
                {
                    double credit = double.Parse(input[1]);
                    totalCredit += credit;
                    totalGrade += credit * creditMap[input[2]];
                }
            }
            sb.Append(totalGrade / totalCredit);
            sw.WriteLine(sb.ToString());
        }
    }
}