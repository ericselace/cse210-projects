using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi you are welcome on our program");
        Console.WriteLine("Please Enter your grade");
        String reponse= Console.ReadLine();
        int percent= int.Parse(reponse);
        

        if (percent >=90)
        {
            Console.WriteLine("you have grade of categorie A");
            if (percent >= 97)
            {
                Console.WriteLine("your grade  A");
            }
            else if (percent >=93 && percent < 97 )
            {
                Console.WriteLine("your grade  A");
            }
            else
            {
                Console.WriteLine("your grade  A-");
            }

        }
        else if (percent >= 80 && percent<90)
        {
            Console.WriteLine("you have grade of categorie B");
            if (percent >= 87)
            {
                Console.WriteLine("your grade  B+");
            }
            else if (percent >=83 && percent < 87 )
            {
                Console.WriteLine("your grade  B");
            }
            else
            {
                Console.WriteLine("your grade  B-");
            }
        }
        else if (percent >= 70 && percent <80)
        {
            Console.WriteLine("you have grade of categorie C");
            if (percent >= 77)
            {
                Console.WriteLine("your grade  C+");
            }
            else if (percent >=73 && percent < 77 )
            {
                Console.WriteLine("your grade  c");
            }
            else
            {
                Console.WriteLine("your grade  c-");
            }
        }
        else if (percent >= 60 && percent <70)
        {
            Console.WriteLine("you have grade of categorie D");
            if (percent >= 67)
            {
                Console.WriteLine("your grade  D+");
            }
            else if (percent >=63 && percent < 67 )
            {
                Console.WriteLine("your grade  D");
            }
            else
            {
                Console.WriteLine("your grade  D-");
            }
        }
        else
        {
          Console.WriteLine("your grade is F");  
        }
        if (percent >=70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }


    }
}