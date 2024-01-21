using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        List<Questions> _qList = new();
        //j._e.Add(new Entry{_eDate=TodaysDate,_eQuestion=Question,_eText=EntryText});
        _qList.Add(new Questions{_qInt=1,_qText="This is the first question"});
        _qList.Add(new Questions{_qInt=2,_qText="This is the 2 question"});
        _qList.Add(new Questions{_qInt=3,_qText="This is the 3 question"});
        _qList.Add(new Questions{_qInt=4,_qText="This is the 4 question"});
        _qList.Add(new Questions{_qInt=5,_qText="This is the 5 question"});
        _qList.Add(new Questions{_qInt=6,_qText="This is the 6 question"});
        _qList.Add(new Questions{_qInt=7,_qText="This is the 7 question"});

        Random r = new Random();
        string fileName =@"C:\Users\meroy\Desktop\Homework\Programming 2\cse210-hw\prove\Develop02\eight.txt";


        

        
        Journal j=new();
        Console.WriteLine("Enter a Title for the Journal");
        j._title=Console.ReadLine();
        Console.WriteLine("Enter your name");
        j._author=Console.ReadLine();
        Console.WriteLine("Enter the Year");
        j._year=Console.ReadLine();
        //Console.WriteLine($"{j._title}, {j._author} {j._year}");
        //Console.WriteLine("Enter Entry");
    
       
        
       
        
        Console.Clear();

        int x=0;
        while (x==0){

        Console.WriteLine("Pick one");
        Console.WriteLine("1. Write new Journal Entry");
        Console.WriteLine("2. Display old Journals");
        Console.WriteLine("3. Load from File");
        Console.WriteLine("4. Save to File");
        Console.WriteLine("5. Quit");
        string firstInput=Console.ReadLine();

        //Create Random Question
        int rInt = r.Next(1,7);
        string RandomQuestion = "";

        //Console.WriteLine($"Random Integer: {rInt}");
        foreach (Questions question in _qList)
            {
                if (question._qInt == rInt)
                {
                    RandomQuestion = question._qText;
                    //Console.WriteLine($"Random Question: {question._qInt}: {question._qText}");
                }

                //Console.WriteLine($"{entry._eDate}: {entry._eQuestion}: {entry._eText}");
            }

        if (firstInput=="1")
        {
            //Console.WriteLine("Enter Todays Date:");
            string TodaysDate=DateTime.Now.ToString("M/d/yy h:mmtt");
            
            //Console.WriteLine("Enter the Question:");
            //string Question=RandomQuestion;
            Console.WriteLine($"{RandomQuestion}");
            //Console.WriteLine("Enter the Entry Text:");
            string EntryText=Console.ReadLine();
            
            j._e.Add(new Entry{_eDate=TodaysDate,_eQuestion=RandomQuestion,_eText=EntryText});

  



          
        }
        else if (firstInput=="2")
        {
            Console.Clear();
          foreach (Entry entry in j._e)
            {
                Console.WriteLine($"{entry._eDate},{entry._eQuestion},{entry._eText}");
            }
        }
        else if (firstInput=="3")
        {
string filename = @"C:\Users\meroy\Desktop\Homework\Programming 2\cse210-hw\prove\Develop02\eight.txt";
string[] lines = System.IO.File.ReadAllLines(filename);

foreach (string line in lines)
{
    string[] parts = line.Split(",");

    string time = parts[0];
    string Question = parts[1];
    string textEntry= parts[2];
    j._e.Add(new Entry{_eDate=time,_eQuestion=Question,_eText=textEntry});
}
        }
        else if (firstInput=="4")
        {
        using (StreamWriter outputFile = new StreamWriter(fileName))
            {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
                foreach (Entry entry in j._e)
                {
                    Console.WriteLine($"{entry._eDate}: {entry._eQuestion}: {entry._eText}");
                    outputFile.WriteLine($"{entry._eDate},{entry._eQuestion},{entry._eText}");
                }

            }
        }
        else{
            x=1;
            break;
        }

        }
    }
}