using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! your are welcome here to determine your Grade");
        Console.WriteLine("plaese write your percente ");
        string value= Console.ReadLine();
        int number = int.Parse(value);
        if (number >= 90 )
          {
            if ( number >=90 && number<93)
              {
                Console.WriteLine("your grade is A-");
              }
            else if ( number>=93 && number<97)
              { 
                Console.WriteLine("your grade is  A");
              }
            else if ( number>97)
              {
                Console.WriteLine("your grade is A+");

              }
          }
          else if (number>=80 && number<90 )
            {
               if ( number >=80 && number<83)
              {
                Console.WriteLine("your grade is B-");
              }
            else if ( number>=83 && number<87)
              { 
                Console.WriteLine("your grade is  B");
              }
            else if ( number>97)
              {
                Console.WriteLine("your grade is A+");

              }
            }
    }
}