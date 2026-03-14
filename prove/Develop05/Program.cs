using System;
//just for a little context i wanted to practice my functions which is why they are seperate.

class Program
{
    static void Main(string[] args)
    {
        List <Goal> goals = new List<Goal>();
        int totPoints = 0;
        bool quit = false;
        do{
            Console.WriteLine("Menu");
            Console.WriteLine("1. Make Goal");
            Console.WriteLine("2. Record Goal");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("0. Exit");
            int user = int.Parse(Console.ReadLine());
            while (user < 0 || user > 5)
            {
                Console.WriteLine("Invalis input. Please try again");
                user = int.Parse(Console.ReadLine());
            }

            if (user == 1)
            {
                goals.Add(CreateGoal());
            }
            else if (user == 2)
            {
                totPoints += RecordGoal(goals);
            }
            else if (user == 3)
            {
                PrintGoals(goals);
            }
            else if (user == 4)
            {
                SaveGoals(goals, totPoints);
            } 
            else if (user == 5)
            {
                LoadGoals("goals.txt", goals, out totPoints);
            }
            else if (user == 0)
            {
                quit = true;
            }
            Console.WriteLine($"\nYou have {totPoints} points.\n");
        } while(!quit);
    }

    static Goal CreateGoal()
    {
        Console.WriteLine("Which kind of goal would you like to make?");
            Console.WriteLine("1. Simple");
            Console.WriteLine("2. Eternal");
            Console.WriteLine("3. Checklist");
            Console.WriteLine("4. Bad habit");
            int usergoal = int.Parse(Console.ReadLine());
            while (usergoal < 1 || usergoal > 4)
            {
                Console.WriteLine("Invalis input. Please try again");
                usergoal = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("What is the name of the goal?");
            string name = Console.ReadLine();
            Console.WriteLine("Provide a brief description");
            string des = Console.ReadLine();
            
            if (usergoal == 1)
            {
                Console.WriteLine("How many points is it worth?");
                int points = int.Parse(Console.ReadLine());
                Goal g = new Simple(name, des, points);
                return g;
            }
            else if (usergoal == 2)
            {
                Console.WriteLine("How many points is it worth?");
                int points = int.Parse(Console.ReadLine());
                Goal g = new Eternal(name, des, points);
                return g;
            }
            else if (usergoal == 4)
            {
                Console.WriteLine("How many points is it worth?");
                int points = int.Parse(Console.ReadLine());
                Goal g = new Vice(name, des, points);
                return g;
            }
            else
            {
                Console.WriteLine("How many times do you want to complete this goal?");
                int compNum = int.Parse(Console.ReadLine());
                Console.WriteLine("How many points for meeting this completion goal?");
                int goalPoints = int.Parse(Console.ReadLine());
                Console.WriteLine("How many points is a single completion?");
                int points = int.Parse(Console.ReadLine());
                Goal g = new Checklist(name, des, points, goalPoints, compNum);
                return g;
            }
            //i know its not clean to have all of the if statements return a value 
            //but because it is created in the loop it has to be returned before it is deleted
    }
    static int RecordGoal(List<Goal> goals)
    {
        SimplePrintGoals(goals);
        Console.WriteLine("Which one did you complete?");
        int resp = int.Parse(Console.ReadLine()) -1;
        
        int earned = goals[resp].RecordGoal();

        if (earned >= 0)
        {
            Console.WriteLine("Congrats on completing your goal.");
            Console.WriteLine($"You gained {earned} points.");
        }
        else
            Console.WriteLine($"You lost {-earned} points.");
        return earned;
    }
    static void PrintGoals(List<Goal> goals)
    {
        int i = 1;
        foreach (Goal g in goals)
            {
                Console.Write($"{i}. ");
                g.PrintGoal();
                i++;
            }
    }
    static void SimplePrintGoals(List<Goal> goals)
    {
        int i = 1;
        foreach (Goal g in goals)
            {
                Console.WriteLine($"{i}. {g.GetName()}");
                i++;
            }
    }
    static void SaveGoals(List<Goal> goals, int totPoints)
    {
        List<string> lines = new List<string>();
        string points = totPoints.ToString();
        lines.Add(points);
        foreach (Goal g in goals)
        {
            string line = g.StoreLine();
            lines.Add(line);
        }

        File.WriteAllLines("goals.txt", lines);
    }
    static void LoadGoals(string filename, List<Goal> goals, out int totPoints)
    {
        goals.Clear();
        string[] lines = File.ReadAllLines(filename);

        totPoints = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            string[] parts = line.Split('|');

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts [3]);

            Goal goal;

            if (goalType == "Simple")
            {
                bool comp = bool.Parse(parts[4]);
                goal = new Simple(name, description, points, comp);
            }
            else if (goalType == "Eternal")
            {
                int comp = int.Parse(parts[4]);
                goal = new Eternal(name, description, points, comp);
            }
            else if (goalType == "Checklist")
            {
                int goalNum = int.Parse(parts[4]);
                int bonusPoints = int.Parse(parts[5]);
                int compCount = int.Parse(parts[6]);
                bool comp = bool.Parse(parts[7]);
                goal = new Checklist(name, description, points, bonusPoints, goalNum, compCount, comp);
            }
            else //i have this last onse as else because if not goal at the end gets mad at me
            {
                bool comp = bool.Parse(parts[4]);
                goal = new Vice(name, description, points, comp);
            }

            goals.Add(goal);
        }
    }
}
