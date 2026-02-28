using System.Globalization;

public class Activity
{
    private string _name;
    private string _description;
    private string _finish;
    private int _duration;

    public Activity (string name, string description, string finish, int duration)
    {
        _name = name;
        _description = description;
        _finish = finish;
        _duration = duration;
    }
    
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetFinish()
    {
        return _finish;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DoTheWave()
    {
        //this one i made to make it less repetitive with writing console lines 
        //but i didnt like the way that it looked while it cycled through
        /*
        for(int i = 0; i<10; i++)
        {
            Console.Write($"\r               ");
            for (int j = 0; j < 10; j++)
            {
                if (i == j)
                {
                    Console.Write("^");
                }
                else
                {
                    Console.Write("-");
                }
            }
            
            Thread.Sleep(200);
        }*/
        Console.Write($"\r^---------");
        Thread.Sleep(200);
        Console.Write($"\r-^--------");
        Thread.Sleep(200);
        Console.Write($"\r--^-------");
        Thread.Sleep(200);
        Console.Write($"\r---^------");
        Thread.Sleep(200);
        Console.Write($"\r----^-----");
        Thread.Sleep(200);
        Console.Write($"\r-----^----");
        Thread.Sleep(200);
        Console.Write($"\r------^---");
        Thread.Sleep(200);
        Console.Write($"\r-------^--");
        Thread.Sleep(200);
        Console.Write($"\r--------^-");
        Thread.Sleep(200);
        Console.Write($"\r---------^");
        Thread.Sleep(200);
    }
    
    public void Intro()
    {
        Console.WriteLine($"You have selected the {_name} activity.");
        Console.WriteLine(_description);

    }
    public void Finish()
    {
        Console.WriteLine($"\n{_finish}");
    }
    public void Countdown(int num)
    {
        for (int i = num; i > 0; i--){
            if(i == 1)
            {
                Console.Write($"\rCountdown: {i} second     ");
                Thread.Sleep(1000);
            }
            else
            {
                Console.Write($"\rCountdown: {i} seconds    ");
                Thread.Sleep(1000);
            }
        }
        Console.WriteLine("\rGo                    \n");
    }

}