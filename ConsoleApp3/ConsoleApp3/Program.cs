using System;


class Program
{
    static void areaCircle() {
        Console.Write("This is Area");
    }
    static void Main(string[] args)
    {
        Console.Write("ENter the name of a shape (Circle , Rectangle: )");
        
        string shapeName = Console.ReadLine();
        if (shapeName == "Circle") 
        {
            areaCircle();
        }
       else if (shapeName == "Rectangle")
        {
            Console.Write("This is Rectangle");
        }
    }
}

