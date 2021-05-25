using System;

namespace Pattern9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = n; j >= 1; j--)
                {
                    if (i >= j)
                    {
                        Console.Write(i+ " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
