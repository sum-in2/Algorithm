using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput())))
            using (StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())))
            {
                String N = sr.ReadLine()!;
                int[] alphabet = Enumerable.Repeat(-1, 26).ToArray();

                for (int i = 0; i < N.Length; i++)
                {
                    int index = N[i] - 'a';
                    if (alphabet[index] == -1)
                    {
                        alphabet[index] = i;
                    }
                }

                sb.Append(string.Join(" ", alphabet));

                sw.WriteLine(sb.ToString());
            }
        }
    }
}