
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
        {
            bool[,] result = new bool[100, 100];
            int N = int.Parse(sr.ReadLine()!);
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                int[] index = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

                for (int y = index[0]; y < index[0] + 10; y++)
                {
                    for (int x = index[1]; x < index[1] + 10; x++)
                    {
                        if (!result[y, x])
                        {
                            result[y, x] = true;
                            cnt++;
                        }
                    }
                }
            }
            sb.AppendLine(cnt.ToString());
            sw.Write(sb.ToString());
        }
    }
}
