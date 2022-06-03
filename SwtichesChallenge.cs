// The Expectation is that you write your own code based
// on what you have learned in the class, it can be what you want
// If you are havind trouble thinging of something, write conditionals
// with the topic of PowerUps, what happens if the powerUp is good or bad.
using System;

public class Program{

    public PowerUps myPowerUps; 
    public BadPowerUps myBadPowerUps;
	
public void PowerUpVars() { // State our powerup vars

}

    public void Main() {
        myPowerUps = new PowerUps(); /// Stating Variables
        myBadPowerUps = new BadPowerUps();
        Random random = new Random();
        int dieRoll = random.Next(1,7);
        int coinFlip = random.Next(1,3);
        int inmateNumber = random.Next(1,99999);
        bool morality = true;

        Console.WriteLine("\"Welcome to Zero's Power-up Testing Facility, I am your host Jacob. Follow me down this hallway and we can get started Test Subject...\" Jacob says as he starts to squint at his clipboard.");
        Console.WriteLine("\"...Number " + inmateNumber + ".\"");

        if (inmateNumber == 1) {
            Console.WriteLine("\"Yeah you're our first test subject. Let's hope nothing goes wrong am I right!.\"");
        } else if (inmateNumber == 2) {
            Console.WriteLine("\"Yeah you're our second test subject. The first guy died a brutal death unlike anything I've ever seen. Legally I have to say that was a joke.\"");
        } else if (inmateNumber <= 100) {
            Console.WriteLine("\"We're still a small company learning the affects of Power-ups. To think we've only had " + (inmateNumber - 2) + " deaths so far.\"");
        } else if (inmateNumber == 666) {
            Console.WriteLine("\"That is perhaps the most unluckiest inmate number I've ever seen. Well lets hope it won't make you unlucky.\"");
            coinFlip = 1;
        } else if (inmateNumber == 777) {
            Console.WriteLine("\"That's quite the lucky number you have there. Hopefully this means you won't die like the other 776 test subjects that came before you.\"");
            coinFlip = 2;
        } else if (inmateNumber <= 1000) {
            Console.WriteLine("\"Wow this is a crazy coincidence. " + inmateNumber + " was my old inmate number in prison. Good times, good times. Until I broke out, killed several officers, escaped, and changed my name to Jacob Donowrong. Legally speaking that is a joke.\"");
        } else if (inmateNumber <= 3000) {
            Console.WriteLine("\"You know you actually remind me of a test subject. I'll never forget it. He was test subject " + (inmateNumber - 1342) + ". He was a really funny guy until he burned to death. Even his last words were, I hate you Jacob, why are you not helping me? I am dying. He was quite the funny guy.\"");
            dieRoll = 1;
        } else if (inmateNumber <= 5000) {
            Console.WriteLine("\"Please don't tell me your name " + inmateNumber + ". They say knowing the names of things before they disappear is bad luck.\"");
        } else if (inmateNumber <= 9000) {
            Console.WriteLine("\"That's a cool test number. I am required to tell you that.\"");
        } else if (inmateNumber <= 13000) {
            Console.WriteLine("\"It might be a minute or two. They're still cleaning up after the last test subject. It's not a pretty picture what happened to poor " + (inmateNumber - 1) +".\"");
        } else if (inmateNumber <= 40000) {
            Console.WriteLine("\"Isn't this fun and exciting! Because it shouldn't be. It should be very scary. These power-ups are very unstable and their affects are terrifying. If you didn't sign a contract I'd tell you to run.\"");
        } else if(inmateNumber == 42069) {
            Console.WriteLine("Jacob says nothing but he giggles like a little school girl after reading your number.");
        } else if(inmateNumber <= 70000) {
            Console.WriteLine("Jacob says nothing the entire way down the hall. It was quite awkward but Jacob had a scared look on his face. Was it guilt perhaps? \"What have you gotten yourself into\" you think to yourself.");
        }else if(inmateNumber <= 92000) {
            Console.WriteLine("\"Kachow! That's my new catchphrase when hearing the new inmate... I mean test subjects number. Number " + (inmateNumber - 5) + " didn't like the catchphrase and look where he is now. Not with us that's for sure. \"");
        } else if(inmateNumber == 999999) {
            Console.WriteLine("\"That's huge.\"");
        } else {
            Console.WriteLine("\"Quite the large number. I've worked here for too long. I remember test subject 5732, he was a cool guy. So cool he froze to death with the ice power-up. It was pretty horrific but I have seen worse since then.\"");
        }

            Console.WriteLine("Jacob and yourself reach the door into the testing room. You both walk into this large room. It is about the size of large meeting room. The only things in the room is a large half circle barrier and round table with a box on top.");
            Console.WriteLine("Jacob walks over to the box and opens it pulling out a weirdly shaped object. Jacob hands you the object.");
            Console.WriteLine("\"Wait for me to get behind this large safe barrier and then you can consume the power-up. Just don't look up and you should be fine.\"");
            Console.WriteLine("Jacob runs behind the large barrier. And not listening to his advice you look up noticing a firing squad ready to shoot in case something goes south.");

        if(coinFlip >= 2) { ///Find out if the power up is going to have a good or bad effect
            morality = true; // Good
        } else if(coinFlip <= 1) {
            morality = false; // Bad
        }

        if(morality == true) {
            myPowerUps.powerUp(dieRoll); // Call to our Powerup class and its code using the values of 1-6
        } else if (morality == false) {
            myBadPowerUps.badPowerUp(dieRoll);
        }

        
    }



}

public class PowerUps { /// Good Powerups

    public void powerUp (int whichPowerUp) {
        switch (whichPowerUp) {
            case 1:
                Console.WriteLine("You've obtained the Fire Power-up! You consume the power-up.");
                Console.WriteLine("You start to feel hotter like you are about to break a sweat. It is rather unconfortable but flames spark at your finger tips. By waving your hands in a circluar motion you are able to create fire balls and throw them with ease.");
                Console.WriteLine("This was a success.");
                break;
            case 2:
                Console.WriteLine("You've obtained the Ice Power-up! You consume the power-up.");
                Console.WriteLine("A sudden chill crawls down your spine and you start to be able to see your own breath. You get the sudden urge to blow as hard as you can, so you do. A blizzard shoots out of your mouth at a great velocity and the table, box, barrier, and Jacob froze rock solid.");
                Console.WriteLine("Although Jacob did not survive due to the blizzard simply going around the barrier freezing Jacob to death. This was a success.");
                break;
            case 3:
                Console.WriteLine("You've obtained the Mega Mushroom Power-up! You consume the power-up.");
                Console.WriteLine("You grow about two inches. This will be a great market for short people. This was a success.");
                break;
            case 4:
                Console.WriteLine("You've obtained the Invincibility Star Power-up! You consume the power-up.");
                Console.WriteLine("Nothing seems to happen. Jacob walks up towards you. \"Huh, I guess that one was faulty. Well typically people don't live from our experiments and frankly if it does have side effects the contract only covers today so we could be sued to the ground. So we are going to have to execute you. Nothing personal.\"");
                Console.WriteLine("Before you can react the firing squad shoot you down. The bullets cannot penetrate your skin. It still hurt but you are indestructable. The firing squad continues to shoot as Jacob is walking away with his back towards you. This is a call for revenge.");
                Console.WriteLine("You run over to Jacob grabbing him and using him as a human shield so the bullets no longer hurt. You leave the room and find a self-destruct button behind a clear case in the hallway. You break into it and hit the button. The faculity explodes and nothing is left but you.");
                Console.WriteLine("You saved the world from the terrors that this faculity that has tested horrible things on people like you. You leave a hero. Living the rest of your days out as a local baker. This power-up was a success.");
                break;
            case 5:
                Console.WriteLine("You've obtained the Duplication Power-up! You consume the power-up.");
                Console.WriteLine("You split into two and as you look up you see another of yourself. The power-up was a success but there shall now forever be two of you. The two of you became political figures and ended up solving world peace as a team.");
                break;
            case 6:
                Console.WriteLine("You've obtained the 1-Up Mushroom Power-up! You consume the power-up.");
                Console.WriteLine("Nothing happens and you go home that day feeling no different. Years go by. You are on your death bed as seven of your wonderful children are there sad. You smile and everything fades to black with your final feelings being satisfied with the life you lived. Instantly you wake back up breathing heavily. You were as young as you were when you originally at the 1-Up power-up. The power-up was a success.");
                break;

        }



    }

}

public class BadPowerUps { /// Bad Powerups
    public void badPowerUp(int whichPowerUp) {
        switch (whichPowerUp) {
            case 1:
                Console.WriteLine("You've obtained the Fire Power-up! You consume the power-up.");
                Console.WriteLine("You are instantly consumed by flames and your skin is replaced with pure fire. You are just a human-shaped fire. The flames consume everything around you and they grow at an alarming rate.");
                Console.WriteLine("They consume Jacob burning him to death and before the issue can get worse the firing squad shot you down. After they put out what was left of the flames everyone lived happliy, except Jacob and you.");
                Console.WriteLine("This power-up was a failure.");
                break;
            case 2:
                Console.WriteLine("You've obtained the Ice Power-up! You consume the power-up.");
                Console.WriteLine("You feel about 10 degrees colder than you should. Nothing else happens and there is nothing you can do to reverse the power-up. You live out the rest of your days slightly cold all the time.");
                Console.WriteLine("This power-up was a failure.");
                break;
            case 3:
                Console.WriteLine("You've obtained the Mega Mushroom Power-up! You consume the power-up.");
                Console.WriteLine("You continue to grow at an alarming rate. From one minute your the size of a basketball player and the next you are as large as the sun. You instantly die in this process and the whole uninverse is consumed by your ever growing body.");
                Console.WriteLine("Technically the power-up is a success but nobody lives to see it.");
                break;
            case 4:
                Console.WriteLine("You've obtained the Invincibility Star Power-up! You consume the power-up.");
                Console.WriteLine("Nothing can stand in your path and the ground beneath you starts to break as if nothing was underneath you. You fall through the entire earth causing it to eventually explode. You spend the rest of eternity floating in space questioning your choices that have lead you to this point.");
                Console.WriteLine("Technically the power-up is a success but nobody lives to see it... except you.");
                break;
            case 5:
                Console.WriteLine("You've obtained the Duplication Power-up! You consume the power-up.");
                Console.WriteLine("You instantly split into two and as you look up and notice there is another verison of you the duplicate attacks you. They choke you out killing you, but before you die they whispers in your ear, \"There can only be one.\"");
                Console.WriteLine("Technically the power-up is a success but you do not live instead a clone of you finally asks that someone you've had on a crush on out on that date you've always thought of asking them on but YOU never had the strength to ask them out. They live out their days together happy.");
                break;
            case 6:
                Console.WriteLine("You've obtained the 1-Up Mushroom Power-up! You consume the power-up.");
                Console.WriteLine("Nothing happens. To test if it works the firing squad shoots you down. You die. The 1-Up did not work. It was a failure.");
                break;
        }

    }
}