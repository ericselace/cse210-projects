using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. Afficher le score");
            Console.WriteLine("2. Lister les objectifs");
            Console.WriteLine("3. Créer un objectif");
            Console.WriteLine("4. Enregistrer un événement");
            Console.WriteLine("5. Quitter");
            Console.Write("Choisissez une option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.DisplayPlayerInfo();
                    break;

                case "2":
                    manager.ListGoalDetails();
                    break;

                case "3":
                    Console.WriteLine("Type d’objectif: 1=Simple, 2=Éternel, 3=Checklist");
                    string type = Console.ReadLine();

                    Console.Write("Nom: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (type == "1")
                        manager.CreateGoal(new SimpleGoal(name, desc, points));
                    else if (type == "2")
                        manager.CreateGoal(new EternalGoal(name, desc, points));
                    else if (type == "3")
                    {
                        Console.Write("Nombre de répétitions: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Bonus: ");
                        int bonus = int.Parse(Console.ReadLine());
                        manager.CreateGoal(new ChecklistGoal(name, desc, points, target, bonus));
                    }
                    break;

                case "4":
                    manager.ListGoalNames();
                    Console.Write("Numéro de l’objectif accompli: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Choix invalide.");
                    break;
            }
        }
    }
}
