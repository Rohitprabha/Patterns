using System;

namespace Pattern10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    if (i >= j)
                    {
                        Console.Write("* ");
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
