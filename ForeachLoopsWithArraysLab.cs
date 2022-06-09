// For Each Loops 

using System;
					
public class Program
{
	public static void Main()
	{
		           // Declare Varibles
        string[] cardTypes = {"Monster", "Spell", "Trap"};

            //Console Write Line
        Console.WriteLine("All the different card types are the following: ");

        foreach (string i in cardTypes) {
            Console.WriteLine(i);
        }
	}
}