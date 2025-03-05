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
            // 배열 "", "", "ABC", ... , "WXYZ" 이렇게 써도 될 듯
            var dial = new Dictionary<char, int>()
            {
                {'A',2},{'B',2},{'C',2},
                {'D',3},{'E',3},{'F',3},
                {'G',4},{'H',4},{'I',4},
                {'J',5},{'K',5},{'L',5},
                {'M',6},{'N',6},{'O',6},
                {'P',7},{'Q',7},{'R',7},{'S',7},
                {'T',8},{'U',8},{'V',8},
                {'W',9},{'X',9},{'Y',9},{'Z',9}
            };

            string input = sr.ReadLine()!;
            sb.Append(input.Sum(c => dial[c] + 1));
            sw.WriteLine(sb.ToString());
        }
    }
}