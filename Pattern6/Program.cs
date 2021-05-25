using System;

namespace Pattern6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i <= j)
                    {
                        Console.Write(" " + j + " ");
                    }
                    else 
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
