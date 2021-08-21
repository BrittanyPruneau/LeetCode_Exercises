using System;
using System.Collections.Generic;
using System.Threading;

namespace FindNumbersWithEvenNumberOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            double[,] grid = new double[4, 4] { { 4, 3, 2, -1 }, { 3, 2, 1, -1 }, { 1, 1, -1, -2 }, { -1, -1, -2, -3 } };
            Console.WriteLine("grid length = {0}", grid.Length);
            Console.WriteLine(grid.LongLength);
            Console.WriteLine("Dimension 1: {0}", grid.GetLength(0));
            Console.WriteLine("Dimension 2: {0}", grid.GetLength(1));

            int count = 0; 
            for ( int i = 0; i < grid.GetLength(0); ++i )
            {
               for (int j =0; j< grid.GetLength(1); ++j)
                {
                    Console.WriteLine(" point: {0}", grid[i, j]);
                    Console.WriteLine("i = {0}", i);
                    Console.WriteLine("j = {0}", j);
                    if (grid[i, j] < 0)
                    {
                        count += 1; 
                    }
                }
         
            }
            Console.WriteLine("The total number of negative values is: {0}", count);

        }
    }
}

