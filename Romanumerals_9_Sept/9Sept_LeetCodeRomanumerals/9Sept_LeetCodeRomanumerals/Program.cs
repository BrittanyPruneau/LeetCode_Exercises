using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public class Program
{

    // convert Romanumerals to Integers.

    public static int RomanToInt(char c)
    {
        int tonumber = 0;
        if (c == 'I')

            tonumber = 1;

        else if (c == 'V')

            tonumber = 5;

        else if (c == 'X')

            tonumber = 10;

        else if (c == 'L')

            tonumber = 50;

        else if (c == 'C')

            tonumber = 100;

        else if (c == 'D')

            tonumber = 500;

        else if (c == 'M')

            tonumber = 1000;


        return tonumber;
    }
    public static void Main()
    {

        // why does it make a difference if I initialize total up here or just above my else if statement? 
        Console.WriteLine("Enter a romanumeral:  ");
        string Romanumeral = Console.ReadLine();

        char[] b = new char[Romanumeral.Length];   // initializing a new character string called b with the length of the romanumeral string the user entered. 
        b = Romanumeral.ToCharArray();
        // converting the string Romanumeral to an array of characters. 

        int[] Integers = new int[Romanumeral.Length];

        for (int i = 0; i < Romanumeral.Length; ++i)
        {

            int number = RomanToInt(b[i]);
            Integers[i] = number;

        }
        // for the length of the array -1 i is the one before and it ends there.
        //we are allowed to use the last one using i+1 of the array
        int total = 0;

        for (int i = 0; i < Romanumeral.Length; ++i)
        {
            if (i != Romanumeral.Length - 1 && Integers[i] < Integers[i + 1])
            {
                total += (Integers[i + 1] - Integers[i]);
                i++;
                continue;
            }
            else
            {
                total += Integers[i];
            }


        }

        Console.WriteLine(total);
    }
}