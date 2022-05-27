using System;
					
public class Program
{
	public void Main()
	{
		    //Declare the Functions and Run Function
		ClassWithVariables cWV = new ClassWithVariables();
		ClassWithFunctions cWF = new ClassWithFunctions();
		cWF.RunSecondFunction();
		
	}
	
	public class ClassExample {
        //Empty sample class
}

public class ClassWithVariables {
        // Declare the Vars
    public int number = 2;
    public string userName = "Bob";
    public float floatNumber = 2.5f;
    public bool earthIsFlat = false;
}

public class ClassWithFunctions {

    public void RunFunction() { // Sample function

            Console.WriteLine("Running Function");
    
    }

    public void RunSecondFunction() { // Run my function
		
			ClassWithVariables classWithVars = new ClassWithVariables();
            Console.WriteLine(classWithVars.userName + " your favorite number is " + classWithVars.number + ". But to be specific your favorie number is " + classWithVars.floatNumber + ".  Human verification required. The Earth is flat: True or False. Correct that is " + classWithVars.earthIsFlat + ".");

    }
    
}
}