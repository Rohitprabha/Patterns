using System;

namespace Pattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - 1; j >= i; j--)
                {
                    Console.Write("   ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" " + i + " ");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 5; i++)
            {
                n = n - 1;
                for (int j = 1; j <= 5; j++)
                {
                    if (j <= n)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(" " + i + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
