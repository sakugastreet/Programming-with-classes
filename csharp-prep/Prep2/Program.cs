using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your Grade?");
        string user_input = Console.ReadLine();
        int value = int.Parse(user_input);

        
        string grade_letter;
        bool passed = true;

        if (value > 90)
        {
            grade_letter = "A";
        }
        else if (value > 80)
        {
            grade_letter = "B";
        }
        else if (value > 70)
        {
            grade_letter = "C";
        }
        else if (value > 60)
        {
            grade_letter = "D";
            passed = false;
        }
        else
        {
            grade_letter = "F";
            passed = false;
        }

        
        if (passed)
        {
            Console.WriteLine($" with a grade of {value}, you passed with a grade {grade_letter}.");
        }
        else
        {
            Console.WriteLine($" with a grade of {value}, you failed with a grade {grade_letter}.");
        }
    }
}