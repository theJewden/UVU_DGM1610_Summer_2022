//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

using System;
					
public class Program
{
	public Puppies puppyOne;
	public Puppies puppyTwo;
	public Puppies puppyThree;
	
	
	public void Main()
	{	
			//Declare puppies
		puppyOne = new Puppies();
		puppyTwo = new Puppies();
		puppyThree = new Puppies();
		
		
		//Puppy Information
		
			//Puppy One
		puppyOne.age = 1;
		puppyOne.breed = "lab";
		puppyOne.name = "Muffin";
		puppyOne.color = "black";
		
			//Puppy Two
		puppyTwo.age = 2;
		puppyTwo.breed = "mutt";
		puppyTwo.color = "gold";
		puppyTwo.name = "Copper";
		
			//Puppy Three
		puppyThree.age = 2;
		puppyThree.breed = "Husky";
		puppyThree.color = "black and white";
		puppyThree.name = "Diego";
		
		
		// Call to console
		
		Console.WriteLine("There are three puppies in the room.");
		Console.WriteLine("There is a " + puppyOne.color + " " + puppyOne.breed + " named " + puppyOne.name + " about the age of " + puppyOne.age + ".");
		Console.WriteLine("There is also a " + puppyTwo.color + " " + puppyTwo.breed + " named " + puppyTwo.name + " about the age of " + puppyTwo.age + ".");
		Console.WriteLine("Lastly, there is also a " + puppyThree.color + " " + puppyThree.breed + " named " + puppyThree.name + " about the age of " + puppyThree.age + ".");
	}
	
	public class Puppies {
		
			//Declare Vars
		public string name;
		public string breed;
		public string color;
		public int age;
	}
	
}