using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int X=1;
  

        while(X==1){

        Console.Clear();
        Console.WriteLine("1:Breathing Activity");
        Console.WriteLine("2:Reflection Activity");
        Console.WriteLine("3:Listing Activity");
        Console.WriteLine("4:Quit");
        string readen=Console.ReadLine();

        Console.WriteLine("How long do you want to do it for(seconds)?");
        string timeIn=Console.ReadLine();

        //if (readen=="1"){_activity="Breathing";}
        //else if (readen=="2"){_activity="Reflection";}
        //else if (readen=="3"){_activity="Listing";}
        //else if (readen=="4"){X=0;break;}
        //else{Console.WriteLine("You are stupid");X=0;break;}

        if (readen=="4"){break;}
        Activity A=new(readen, timeIn);
        A.activityStart();
        

    }
    }
}