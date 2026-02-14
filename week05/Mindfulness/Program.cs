using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("=== Mindfulness App ===");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine() ?? "4";
            Activity? activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectingActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
            }

            
            activity.DisplayStartingMessage();
            activity.Run();
            activity.DisplayEndingMessage();

            Console.WriteLine(); 
        }
    }
}
