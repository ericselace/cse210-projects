using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userprint = -1;
        while ( userprint !=0 )
        {
           Console.WriteLine("enter your number , if you want to quit please write 0."); 
           userprint=int.Parse(Console.ReadLine());

           if (userprint != 0)
           {
           numbers.Add(userprint);
           }
        }
        int sum=0;
        
        foreach( int number in numbers)
        {
           sum += number ;
        }
        
        Console.WriteLine($"the summe of the all numbers is {sum}");
         
        float average = sum/ numbers.Count;
        Console.WriteLine($"the averages {average}");

        int larger= numbers[0];

        foreach (int number in numbers)
        {
            if (number < larger)
            {
                larger=number;
            }
        }

        Console.WriteLine($"the largest is{larger} ");

        
    }
}