using System;
namespace simple
{

	public class task3
	{

		public static void Main()
		{

			Console.WriteLine("Argument at runtime " + args[0] + args[1] + args[2]);
			int num1 = int.Parse(args[1]);
			int num2 = int.Parse(args[2]);
			if (args[0] == "+")
			{
				Console.WriteLine("Addition: " + (num1 + num2));
			}
			if (args[0] == "-")
			{
				Console.WriteLine("Subtraction: " + (num1 - num2));
			}
			if (args[0] == "*")
			{
				Console.WriteLine("Multiplication: " + (num1 * num2));
			}
			if (args[0] == "/")
			{
				Console.WriteLine("Division: " + (num1 / num2));
			}

		}
	}
}