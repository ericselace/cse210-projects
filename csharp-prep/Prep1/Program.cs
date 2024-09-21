using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("please write your first name ");
        string firstname = Console.ReadLine();

        Console.WriteLine("what is family name?");
        string familyname = Console.ReadLine();

        Console.WriteLine($"your name {firstname} {familyname}");
    }
}