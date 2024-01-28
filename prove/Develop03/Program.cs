using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture Scr=new();
        Word Wor=new();
        Reference refs=new();

        Scr.splitScripture();

        string fullScripture="And all these things, of which I have spoken, were done as my father dwelt in a tent, in the valley of Lemuel. ";
        Console.Clear();
        string fullReference=refs.GetDisplayText();

        Console.WriteLine(fullReference);
        Console.WriteLine(fullScripture);




    string userInput=Console.ReadLine();
        if (userInput=="quit")
        {}
        else{
            
        }

    }
}