using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("Hello Gay Bowser!");

        string first_name;
        string last_name;

        Console.WriteLine("what is your name?");
        first_name = Console.ReadLine();
        Console.WriteLine("what is your last name?");
        last_name = Console.ReadLine();
        Console.WriteLine($"It is nice meet you {last_name}, {first_name} {last_name}.");


    }
}