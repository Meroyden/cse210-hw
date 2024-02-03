
using System;
using Microsoft.VisualBasic;

public class ReflectingActivity
{
    int _time;

    public ReflectingActivity(string time){
        _time=Int16.Parse(time);
        _time*=60;
    }

         private string _prompt1="Think of a time when you stood up for someone else.";
        private string _prompt2="Think of a time when you did something really difficult.";
        private string _prompt3="Think of a time when you helped someone in need.";
        private string _prompt4="Think of a time when you did something truly selfless.";

   


        private string[] _prompts={_prompt1, _prompt2,_prompt3,_prompt4};
        private Random _random=new();
        _random=_prompts.next();
        private string whatever;


        private string _thought1="Why was this experience meaningful to you?";
        private string _thought2="Have you ever done anything like this before?";
        private string _thought3="How did you get started?";
        private string _thought4="How did you feel when it was complete?";
        private string _thought5="What made this time different than other times when you were not as successful?";
        private string _thought6="What is your favorite thing about this experience?";
        private string _thought7="What could you learn from this experience that applies to other situations?";
        private string _thought8="What did you learn about yourself through this experience?";
        private string _thought9="How can you keep this experience in mind in the future?";

    //private string[] _thoughts={_thought1, _thought2,_thought3,_thought4,_thought5,_thought6,_thought7,_thought8,_thought9};
    private List<string> questions = new() { "Why was this experience meaningful to you?","Have you ever done anything like this before?" };
    private List<int> numbers = new() {1,2,3,4,5,6,7,8,9};

    Random r = new Random();
    int rInt = r.Next(0, 9);

    private Random _random2=new();
        _random2=_thoughts.next();


    public void aBegin(){
        DateTime currentTime = DateTime.Now;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        while(futureTime>currentTime){
        Console.Clear();
        Console.WriteLine(_random);
        Thread.Sleep(10000);
        Console.WriteLine();
        Console.WriteLine(_random2);
        Thread.Sleep(10000);
        }
    }

}