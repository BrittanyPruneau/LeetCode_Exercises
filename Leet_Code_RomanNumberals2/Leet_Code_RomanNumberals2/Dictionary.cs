// C# Program to convert Roman 
// Numerals to Numbers 
using System;

class GFG
{
	// This function returns value 
	// of a Roman symbol 
	public virtual int value(char r)
	{
		if (r == 'I')
			return 1;
		if (r == 'V')
			return 5;
		if (r == 'X')
			return 10;
		if (r == 'L')
			return 50;
		if (r == 'C')
			return 100;
		if (r == 'D')
			return 500;
		if (r == 'M')
			return 1000;
		return -1;
	}

	// Finds decimal value of a 
	// given romal numeral 
	public virtual int romanToDecimal(string str)
	{
		// Initialize result 
		int res = 0;

		for (int i = 0; i < str.Length; i++)     //  for the string XLI; increment i 
		{
			// Getting value of symbol s[i] 
			int s1 = value(str[i]);				// value is a method that returns an integer and expects a char. 

			// Getting value of symbol s[i+1] 
			if (i + 1 < str.Length)  
			{
				int s2 = value(str[i + 1]);   // saving the integer (converted from ROmanumeral. 

				// Comparing both values 
				if (s1 >= s2)					// IN XLI (s1 = current X) (s2 = next L)  if X >= L  add X. if X<L add L and subtract X  
				{								// X = 10   L = 50   so, XLI  XL = +50 -10  
												// then LI =>     (s1 = current L) (S2 = next I)  if L >=I add X 
												// L = 50  I = 1
										
					// Value of current symbol is greater 
					// or equalto the next symbol 
					res = res + s1;
				}
				else
				{
					res = res + s2 - s1;
					i++; // Value of current symbol is 
						 // less than the next symbol 
				}
			}
			else
			{
				res = res + s1;
				i++;
			}
		}

		return res;
	}

	// Driver Code 
	public static void Main(string[] args)
	{
		GFG ob = new GFG();

		// Considering inputs given are valid 
		string str = "VLL";   // V = 5 L = 50 
		Console.WriteLine("Integer form of Roman Numeral"
						+ " is " + ob.romanToDecimal(str));
	}
}

// This code is contributed by Shrikant13 

