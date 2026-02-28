using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Threading;
public class Breathing : Activity
{
    private int _breatheIn;
    private int _breatheOut;
    
    public Breathing(string name, string description, string finish, int duration, int bin, int bout) 
    : base (name, description, finish, duration)
    {
        _breatheIn = bin;
        _breatheOut = bout;
    }
    public void Cycle()
    {
        
        
        for (int i = _breatheIn; i > 0; i--){
            if(i == 1)
            {
                Console.Write($"\rBreathe in: {i} second     ");
                Thread.Sleep(1000);
            }
            else
            {
                Console.Write($"\rBreathe in: {i} seconds    ");
                Thread.Sleep(1000);
            }
        }
        Console.WriteLine("\rBreathe in:                ");

        for (int i = _breatheOut; i > 0; i--)
        {
            if(i == 1)
            {
                Console.Write($"\rBreathe out: {i} second    ");
                Thread.Sleep(1000);
            }
            else
            {
                Console.Write($"\rBreathe out: {i} seconds   ");
                Thread.Sleep(1000);
            }
        }
            Console.WriteLine("\rBreathe out:              ");
        

       
    }
}