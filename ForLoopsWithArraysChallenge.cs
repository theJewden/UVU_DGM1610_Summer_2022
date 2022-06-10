using System;

public class Program {
    public void Main() {
            // Define Vars
        string[] bestNintendoGames = {"Legend of Zelda", "Super Mario", "Metroid", "Super Smash Bros", "Pokemon"};
        Console.WriteLine("Some of Nintendo's best games are the following: ");

        for(int i = 0; i < bestNintendoGames.Length; i++) {
            Console.WriteLine(bestNintendoGames[i]);
        }
    }
}