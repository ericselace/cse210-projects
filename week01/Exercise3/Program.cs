using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator=new Random();
        int number =randomGenerator.Next(1,101);
        Console.WriteLine($"{number}"); 
        
        int guess =-1;

        while (guess != number )
        {
            Console.WriteLine("Please enter your number");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Highers");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lowers");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

            
        }

    }
}