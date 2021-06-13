using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] itemnametype = itemnametype = new string[n,2];
            for (int i = 0; i <= n-1; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    itemnametype[i, j] = Console.ReadLine();
                }
            }
            string mode = Console.ReadLine();
            if (mode == "ShowAll")
            {
                for (int i = 0; i <= n - 1; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.WriteLine(itemnametype[i, j]);
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("End");
            }
        }
    }
}
