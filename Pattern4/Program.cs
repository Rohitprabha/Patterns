using System;

namespace Pattern4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                for (int j = n - 1; j >= i; j--)
                {
                    Console.Write("   ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" " + k + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                n = 1;
                for (int j = 1; j <= 5; j++)
                {
                    if (j < i)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(" " + n++ + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
