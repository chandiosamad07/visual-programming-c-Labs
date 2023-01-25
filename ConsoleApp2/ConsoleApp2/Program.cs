using System;

namespace ConsoleApp2
{
  public class Program
    {
        public static void Main(String []args)
        {
            Console.WriteLine("Enter the name of Shape (Circle, Rectange) : ");
            string shapeName = Console.ReadLine();

            if (shapeName == "Circle")
            {
                areaCircle();
            }
            else if (shapeName == "Rectangle")
            {
                Console.WriteLine("This is Rectangle");
            }

        }
        public static void areaCircle() {
            Console.WriteLine("This is Circle");
        }
    }
}
