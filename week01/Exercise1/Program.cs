using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is yor first name?");
        String first= Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        String last=Console.ReadLine();


        Console.WriteLine($"your name is:{last} {first}");
    }
}