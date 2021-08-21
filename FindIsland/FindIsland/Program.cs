using System;

namespace FindIsland
{
    class Program
    {
        public static void Main()
        {

            int[,] M = new int[,] { { 1, 1, 0, 0, 0 },
                                  { 0, 1, 0, 0, 1 },
                                  { 1, 0, 0, 1, 1 },
                                  { 0, 0, 0, 0, 0 },
                                  { 1, 0, 1, 0, 1 } };
            Console.Write("Number of islands is: ");
        }
    }

}
