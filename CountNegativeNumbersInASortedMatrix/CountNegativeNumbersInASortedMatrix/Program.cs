using System;

namespace CountNegativeNumbersInASortedMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // GREGS SOLUTION 
            string text = "baldfloondfballoodfn";

            int countA = 0;
            int countB = 0;
            int countL = 0;
            int countN = 0;
            int countO = 0;
            int balloonCount = 0;

            char[] charText = text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {

                switch (text[i])
                {
                    case 'a': countA++; break;
                    case 'b': countB++; break;
                    case 'l': countL++; break;
                    case 'o': countO++; break;
                    case 'n': countN++; break; 
                }
            }
            while (countB > 0 && countA > 0 && countL > 1 && countO > 1 && countN > 0)
            {


                balloonCount++;

                countB--;

                countA--;

                countL -= 2;

                countO -= 2;

                countN--;



                Console.WriteLine("test: {0} ", balloonCount); }
            Console.WriteLine("test: {0} ", balloonCount)

                } 
        }
    }



