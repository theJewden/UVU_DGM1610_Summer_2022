// For Loops with Arrays

using System;

public class Program
{
    public void Main() {

            // Declare the vars
        string[] milkShakes = {"Vanilla", "Chocolate", "Strawberry", "Cookies and Cream", "Specialty Flavor"};
        Random random = new Random(); // Declare random var
        int specialtyFlavors = random.Next(1,5); // Using random var 1-4

            // Switch statement to change specialty flavor
        switch(specialtyFlavors) {
            case 1:
                milkShakes[4] = "Raspberry";
                break;
            case 2:
                milkShakes[4] = "Blueberry Muffin";
                break;
            case 3:
                milkShakes[4] = "Snickerdoodle";
                break;
            case 4:
                milkShakes[4] = "Birthday Cake";
                break;
        }

            //Write Console before For Loop
        Console.WriteLine("Today's Milkshake Flavors: ");

            //For Loop
        for (int i = 0; i <= 4; i++) {
            Console.WriteLine(milkShakes[i]);
        }

    }
}