using System;

namespace Pattern5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" " + j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
