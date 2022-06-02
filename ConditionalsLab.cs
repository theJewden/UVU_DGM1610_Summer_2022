using System;
					
public class Program
{
	public Operations myOperator;
    public OperationsTwo myOperatorTwo;
	public SwitchOne mySwitch;
	public AntCode myAC;
	
	public void Main()
	{ 
		myOperator = new Operations();
        myOperatorTwo = new OperationsTwo();
		mySwitch = new SwitchOne();
		myAC = new AntCode();
		Random random = new Random(); // Set our randomization
		int dieRoll = random.Next(1,7); // Random number between 1 and 6
		
		Console.WriteLine("Welcome"); // Previous Code by Anthony
		myOperator.DoMath(10, 4);
		myOperator.DoMath(20, 7);
		myOperator.DoMath(30, 15);
		myAC.Compare(4,3);
		myAC.Compare(3,4);
		myAC.CheckPassword("SevenOF9");
		myAC.CheckPassword("OU812");

                                        // My code
        myOperatorTwo.MoreMath(10,15,15, true);
        myOperatorTwo.MoreMath(20,15,4, false);
		mySwitch.switchFun(dieRoll);


	} 
}

public class Operations { 
	public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}

public class OperationsTwo {
    public void MoreMath (int value, int value2, int value3, bool value4) {
        int value5 = 1; // Declare Values
        var number = ((value + value2) - value3) * value5; 
            if (value4 == true) { //Find if value4 (true or false)
                value5 = 2;
            } else {
                value5 = 1;
            }
        Console.WriteLine(number); // Write line in console
    }
}

// Switch Statement

public class SwitchOne {
	public void switchfun(int powerLevel) {
		Console.WriteLine("I shall now evaluate your power level.");
			switch(powerLevel) {
				case 0:
					Console.WriteLine("You are very weak.");
					break;
				case 1:
					Console.WriteLine("Not the weakest I have seen but still pathetic.");
					break;
				case 2:
					Console.WriteLine("Beyond average. I bet my grandma could still beat you up.");
					break;
				case 3:
					Console.WriteLine("You're okay. But if you end up in a fight my money is on the other guy.");
					break;
				case 4:
					Console.WriteLine ("You are strong! Not that strong. But you are strong!");
					break;
				case 5:
					Console.WriteLine("I ain't messing with you. You're really beefy.");
					break;
				case 6:
					Console.WriteLine("It's over 9000!!!");
					break;
			}

	}

}





    }


	public class AntCode {
	
	public void Compare (int value, int value2) {
		if(value > value2) {
			Console.WriteLine("True, " + value + " is greater.");
		} else {
			Console.WriteLine("False," + value2 + " is greater.");
		}
	}
	
	public void CheckPassword (string password) {
		if(password == "OU812") {
			Console.WriteLine("Correct Password");
		} else {
			Console.WriteLine("Incorrect Password");	
		}
	}

}	