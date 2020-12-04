using System;

namespace AdventOfCodeCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			var dayOne = new DayOne(1, "dayOne-input.txt");
			dayOne.Display(dayOne.PartOne());
			dayOne.Display(dayOne.PartTwo());



			Console.ReadLine();
		}
	}
}
