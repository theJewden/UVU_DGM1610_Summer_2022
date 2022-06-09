// While Loops 
using System;
					
public class Program
{
	public void Main()
	{

int playerHealth = 100;

do {
    playerHealth -= 10;
    Console.WriteLine("You took damage your health is now at " + playerHealth + "!");
}

while (playerHealth > 0);

if (playerHealth == 0) {
    Console.WriteLine("Your health has reached 0. GAME OVER.");
}
	}
}