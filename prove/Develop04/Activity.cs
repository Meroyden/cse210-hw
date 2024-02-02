using System;

public class Activity
{

    private string _option;
    private string _time;

    public Activity(string option, string time){
        _option=option;
        _time=time;
    }
    public void activityStart(){
        if (_option=="1"){_option="Breathing";}
        else if (_option=="2"){_option="Reflection";}
        else if (_option=="3"){_option="Listing";}

        Console.Clear();
        Console.WriteLine($"Welcome to the {_option} activity!\n");
        Console.WriteLine(_option);
        Thread.Sleep(5000);
        Console.Write("We shall begin in\n3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);



        if(_option=="Breathing"){
            BreathingActivity bA=new(_time);
            bA.aBegin();
        }
        else if(_option=="Reflection"){
            ReflectingActivity rA=new(_time);
            rA.aBegin();
        }
        else if(_option=="Listing"){
            ListingActivity lA=new(_time);
            lA.aBegin();
        }

        Console.Clear();
        Console.WriteLine("You have completed your activity");
        Thread.Sleep(6000);
        Console.WriteLine("What would you like to do?\n");

    }

}