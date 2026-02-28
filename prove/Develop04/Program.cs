using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        do{
            Console.WriteLine("Welcome to the Wellness center. ");
            Console.WriteLine("1. Breathing ACtivity.");
            Console.WriteLine("2. Reflecting Activity.");
            Console.WriteLine("3. Listing ACtivity.");
            Console.WriteLine("4. Visualization ACtivity.");
            Console.WriteLine("0. Quit.");
            string resp = Console.ReadLine();

            while(resp != "1" && resp != "2" && resp != "3" && resp != "0" && resp != "4")
            {
                Console.WriteLine("I'm sorry but that isnt a valid response please try again.");
                resp = Console.ReadLine();
            }
            
            int userDuration = 0;
            bool isValid = false;

            while(!isValid && resp != "0" && resp != "4")
            {
                Console.Write("How long would you like to participate in the activity for: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out userDuration))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("That was not a valid number. Please try again.");
                }
            }
            
            if (resp == "1")
            {
                Breathing b = new Breathing("Breathing", 
                "This activity will help you relax by walking your through breathing in and out slowly. "
                + "Clear your mind and focus on your breathing.", 
                "Thank you for completing the activity", userDuration, 4, 6);
                b.Intro();
                b.Countdown(10);
                
                Stopwatch stopwatch = Stopwatch.StartNew();
                TimeSpan duration = TimeSpan.FromSeconds(b.GetDuration());
                
                while (stopwatch.Elapsed < duration)
                {
                    b.Cycle();
                }
                b.Finish();
                Thread.Sleep(3000);

            }
            else if (resp == "2")
            {
                Reflection r = new Reflection("Reflecting", 
                "This activity will help you reflect on times in your life when you have shown strength and resilience. "
                + "This will help you recognize the power you have and how you can use it in other aspects of your life.", 
                "Thank you for completing the activity" ,userDuration, 10);
                r.Intro();
                r.RunPrompt();
                r.Countdown(10);
                r.RunQuestion();
                r.Finish();
                Thread.Sleep(3000);

            }
            else if (resp == "3")
            {
                Listing l = new Listing("Listing",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                "Thank you for completing the activity", userDuration);
                l.Intro();
                l.RunPrompt();
                l.Countdown(10);

                
                Stopwatch stopwatch = Stopwatch.StartNew();
                TimeSpan duration = TimeSpan.FromSeconds(l.GetDuration());
                
                while (stopwatch.Elapsed < duration)
                {
                    l.GetResponses(l.GetCount());
                }
                Console.WriteLine($"Your gave {l.GetCount()} responses");
                l.Finish();
                Thread.Sleep(3000);

            }
            else if (resp == "4")
            {
                Visualization v = new Visualization("Visualization", 
                "The antidote to anxiety is action this will give you some questions to help you with this action. You will get out what you put into this activity.", 
                "Thank you for completing this activity", 0);

                v.Intro();
                v.Countdown(10);

                foreach (string q in v.GetQuestion())
                {
                    Console.WriteLine(q);
                    Console.ReadLine();
                }
                v.Finish();
                Thread.Sleep(3000);

            }
            else
            {
                quit = true;
            }


            


        }while(!quit);
    }
}





