using System;
public class BreathingActivity
{
    private int _time;
    
    public BreathingActivity(string time){
        _time=Int16.Parse(time);
        _time*=100;
    }
    public void aBegin(){
        DateTime currentTime = DateTime.Now;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        while(futureTime>currentTime){
            Console.Clear();
            Console.WriteLine(currentTime);
            Console.WriteLine(futureTime);
            Console.WriteLine("Breath in.\n");
            Console.WriteLine("3");
            Thread.Sleep(1500);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1500);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1500);
            
            Console.Clear();
            Console.WriteLine("Breath out...\n");

            Console.WriteLine("3");
            Thread.Sleep(1500);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1500);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1500);
            currentTime = DateTime.Now;
        }


    }

}