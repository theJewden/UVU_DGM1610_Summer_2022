using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	public Hero heroFour;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
        heroThree = new Hero();
        heroFour = new Hero();
		
            //Hero One Stats
		heroOne.health = 2;
		heroOne.powerLevel = 5;
        heroOne.heroName = "Steven";
        heroOne.gainedExp = 352;

		
            //Hero Two Stats
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
        heroTwo.heroName = "Joshua";
        heroTwo.gainedExp = 627;


            //Hero Three Stats
        heroThree.health = 10;
        heroThree.powerLevel = 7;
        heroThree.heroName = "The Tank";
        heroThree.gainedExp = 342;


            // Hero Four Stats
        heroFour.health = 5;
        heroFour.powerLevel = 2;
        heroFour.heroName = "Melissa";
        heroFour.gainedExp = 732;
		
			// Find new Power Level
        heroOne.FindPowerLevel();
        heroTwo.FindPowerLevel();
        heroThree.FindPowerLevel();
        heroFour.FindPowerLevel();

		Console.WriteLine("Battle completed! Player Stats Summary: " ); // Console

        Console.WriteLine(heroOne.heroName + " gained " + heroOne.gainedExp + " exp. " + heroOne.heroName + " is now level " + heroOne.powerLevel + " They also currently have " + heroOne.health + " health left.");
        Console.WriteLine(heroTwo.heroName + " gained " + heroTwo.gainedExp + " exp. " + heroTwo.heroName + " is now level " + heroTwo.powerLevel + " They also currently have " + heroTwo.health + " health left.");
        Console.WriteLine(heroThree.heroName + " gained " + heroThree.gainedExp + " exp. " + heroThree.heroName + " is now level " + heroThree.powerLevel + " They also currently have " + heroThree.health + " health left.");
		Console.WriteLine(heroFour.heroName + " gained " + heroFour.gainedExp + " exp. " + heroFour.heroName + " is now level " + heroFour.powerLevel + " They also currently have " + heroFour.health + " health left.");
	}
}

public class Hero {

    // Declare the hero vars
	public int health;
	public int powerLevel;
    public int exp = 0;
    public int gainedExp = 0;
    public int maxExp = 100;
    public string heroName;

    public void FindPowerLevel() {

        for(exp = gainedExp; exp>maxExp; exp -= maxExp) { // Determine Power Level
            powerLevel += 1; // Level up
        }
    }

}