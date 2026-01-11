using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcomeMessage ()
    {
       Console.WriteLine("your are welcone to the program");
    }
    static String PromptUserName()
    {
        Console.WriteLine("Please enter your username");
        string Name= Console.ReadLine();
        return Name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int numbers = int.Parse(Console.ReadLine());

        return numbers;
    }
    static int SquareNumber(int number)
    {
        int Numbersquare = number * number;
        return Numbersquare;
    }
    static void DisplayResult(string name,int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

        
    
}