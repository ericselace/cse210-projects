using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1= new Job();
        Job1._jobTitle = "Software Engineer"; 
        Job1._company = "Microsoft"; 
        Job1._startYear = 2021; 
        Job1._endYear = 2023;
        Console.WriteLine("Job 1 Company: " + Job1._company);

        Job Job2 = new Job();
        Job2._jobTitle = "Data Analyst"; 
        Job2._company = "Google"; 
        Job2._startYear = 2005; 
        Job2._endYear = 2020;
        
    }
}