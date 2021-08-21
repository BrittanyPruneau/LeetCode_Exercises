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
        for (int j = 0, k = 1; k <= Romanumeral.Length; ++j, ++k)
        {

            int currentnumber = Integers[j];
            int nextnumber = Integers[k];

            if (k >= Integers.Length)
            {
                total += currentnumber;

            }

            else if (k >= Integers.Length)
            {
                if (nextnumber > currentnumber)
                {
                    total = total + (nextnumber - currentnumber);
                    total = Convert.ToInt32(total);
                    break;
                }
                if (nextnumber > currentnumber)
                    total += currentnumber;
                     break;
            }
           
                if (currentnumber >= nextnumber)
                {
                    total += currentnumber;
                    total = Convert.ToInt32(total);
                }

            if (nextnumber > currentnumber)
            {
                total = total + (nextnumber - currentnumber);
                total = Convert.ToInt32(total);
                
            }



        }
        Console.WriteLine(total);

    }
}


//(int[] final, double newtotal) = ConvertingToArrayOfIntegers(number, Romanumeral);
//Console.WriteLine("Finally I get to see final {0} and somethingnew {1}", newtotal, final);


//static (int[], double) ConvertingToArrayOfIntegers(int number, string Romanumeral) // since they are already ints. 
//   // we put them into an array first so we can loop through it and do the comparison and add.
//{
//    double total = 0;
//    int[] Integers = new int[Romanumeral.Length];
//    for (int i = 0; i < Romanumeral.Length; i++)
//    {
//        for (int j = 1; j < Romanumeral.Length; j++)
//        {
//            int currentNumb = Integers[i];
//            int nextNumb = Integers[j];


//            if (currentNumb < nextNumb)
//            {
//                total = total + (nextNumb - currentNumb);
//                total = Convert.ToInt32(total);
//            }
//            if (currentNumb >= nextNumb)
//            {
//                total = total + currentNumb + nextNumb;
//                total = Convert.ToInt32(total);
//            }
//        }
//    }
//    Console.WriteLine(total);

//    return (Integers, total);
//}

//}





//for (int i = 0; i < romanumeral.length - 1; ++i)  // for each character in the string, if current < next  +(next - current)


//    int currentchar = Integers[i];
//char nextchar = b[i + 1];
//if (currentchar < nextchar)
//{
//    total = total + (nextchar - currentchar);

//}
//else if (currentchar >= nextchar)
//{
//    total = total + currentchar;
//}
//    }

//    Console.WriteLine("The integer conversion of the romanumeral you've entered is:  {0}", total);
//    }
//}



//                foreach (char s in b)
//{
//    {

//        int theNumbers;
//        theNumbers = RomanToInt(s);
//        total = total + theNumbers;
//    }

//int tonumber;
//switch (c)
//{
//    case 'I':
//        tonumber = 1;
//        return tonumber;
//    case 'V':
//        tonumber = 5;
//        return tonumber;
//    case 'X':
//        tonumber = 10;
//        return tonumber;
//    case 'L':
//        tonumber = 50;
//        return tonumber;
//    case 'C':
//        tonumber = 100;
//        return tonumber;
//    case 'D':
//        tonumber = 500;
//        return tonumber;
//    case 'M':
//        tonumber = 1000;
//        return tonumber;
//}
//int i = 10;
//return i;




