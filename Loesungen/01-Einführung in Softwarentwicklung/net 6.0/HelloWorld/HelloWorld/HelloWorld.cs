using System;

class HelloWorld
{
    static void Main(string[] args)
    {
        Console.Write("Dein Name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Hi " + name + ", willkommen in der Welt des Programmierens.");
        Console.WriteLine("");
        Console.WriteLine("zum Beenden Taste drücken.");
        Console.ReadKey();
    }
}

