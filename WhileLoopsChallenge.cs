// While Loops Challenge
using System;

public class Program {
    public void Main() {
            //Define Vars
        string[] alphaResponse = {"a","b","c","d"};
        string[] playerClass = {"Undecided", "Warrior", "Mage", "Brawler", "Archer"}; // Player Classes
        int storedPlayerClass = 0;

            //Get name and class
        Console.WriteLine("Welcome to Dungeon Crawlers I am your host, \"The Unembodied\". What is your name hero? (Type your name below)");
        string userName = Console.ReadLine(); // Get user input
        do { // Redo this line of code if the player responds wrong
            Console.WriteLine("Ah " + userName + ". That certainly is a name you could have. Now you must choose a class. What would you like to be?");
            for(int i = 1; i < playerClass.Length; i++) {
                Console.WriteLine(alphaResponse[(i-1)] + ") " + playerClass[i]); // Should display 4 that look like this "a) Warrior"
            }
            string responseOne = Console.ReadLine(); //a = warrior, b = mage, c = brawler, d = archer

                //Find response
            if(responseOne == "a" || responseOne == "A") {
                storedPlayerClass = 1;
            } else if(responseOne == "b" || responseOne == "B") {
                storedPlayerClass = 2;
            } else if(responseOne == "c" || responseOne == "C") {
                storedPlayerClass = 3;
            } else if(responseOne == "d" || responseOne == "D") {
                storedPlayerClass = 4;
            } else {
                storedPlayerClass = 0;
            }
        }
        while (storedPlayerClass == 0);

                 //Declare Class to player
            Console.WriteLine("Ah a natural born " + playerClass[storedPlayerClass] + ".");
        switch(storedPlayerClass) {
            case 1: // Warrior
                Console.WriteLine("The loyal class with armor. You must have been born to fight!");
                break;
            case 2: // Mage
                Console.WriteLine("That's quite the scholar class you chose. You must be very wise!");
                break;
            case 3: // Brawler
                Console.WriteLine("How barbaric! You must have great strength!");
                break;
            case 4: // Archer
                Console.WriteLine("You'll need a steady hand with that class! You must have great aim.");
                break;

        }
    }
}