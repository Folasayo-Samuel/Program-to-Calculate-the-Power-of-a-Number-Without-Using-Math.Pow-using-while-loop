using System;

namespace PowerNumberWithoutMath;
public class Program
{
	public static void Main(string[]args)
	{
		int baseNumber, expNumber, result = 1;
		Console.Write("Base Number: ");
		baseNumber = Convert.ToInt32(Console.ReadLine());
		Console.Write("Exponent Number: ");
		expNumber = Convert.ToInt32(Console.ReadLine());
		
		while(expNumber != 0)
		{
			result *= baseNumber;
			--expNumber;
		}

		Console.WriteLine($"Result = {result}");

        Console.ReadLine();
    }
}