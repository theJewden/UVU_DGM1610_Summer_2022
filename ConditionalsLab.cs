using System;
					
public class Program
{
	public Operations myOperator;
    public OperationsTwo myOperator2;
	
	public void Main()
	{
		myOperator = new Operations();
        myOperator2 = new OperationsTwo();
		
		Console.WriteLine("Welcome"); // Previous Code by Anthony
		myOperator.DoMath(10, 4);
		myOperator.DoMath(20, 7);
		myOperator.DoMath(30, 15);
		myOperator.Compare(4,3);
		myOperator.Compare(3,4);
		myOperator.CheckPassword("SevenOF9");
		myOperator.CheckPassword("OU812");

                                        // My code
        myOperator2.MoreMath(10,15,15, true);
        myOperator2.MoreMath(20,15,4, false);

	}
}

public class Operations {
	public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}

public class OperationsTwo {
    public void MoreMath (int value, int value2, int value3, bool value4) {
        int value5; // Declare Values
        var number = ((value + value2) - value3) * value5; 
            if (value4 == true) { //Find if value4 (true or false)
                value5 = 2;
            } else {
                value5 = 1;
            }
        Console.WriteLine(number); // Write line in console
            


    }
}


    }
}
	
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