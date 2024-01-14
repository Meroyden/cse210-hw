using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Pick a number between 1 and 100");
        //int correct = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int correct = randomGenerator.Next(1, 101);
        int guess=0;


        while (correct!=guess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (correct > guess)
            {Console.WriteLine("Higher");}

            else if (correct < guess)
            {Console.WriteLine("Lower");}

            else
            {Console.WriteLine("You guessed it!");}
        }
    }
}