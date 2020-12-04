using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCodeCSharp
{
	class DayOne
	{
		private readonly int day;
		private readonly string fileName;
		private readonly List<string> lines;

		public DayOne(int _day, string _fileName)
		{
			this.day = _day;
			this.fileName = _fileName;
			this.lines = Utilities.ReadFile(_day, _fileName);
		}
		
		public void Display(dynamic result)
		{
			Console.WriteLine(result);
		}

		public int PartOne()
		{
			var expenses = lines.Select(line => int.Parse(line));
			int sum = 0;
			foreach(var a in expenses)
			{
				foreach(var b in expenses)
				{
					if (a + b == 2020) return sum + (a * b);
				}
			}

			return sum;
		}

		public int PartTwo()
		{
			var expenses = lines.Select(line => int.Parse(line));
			int sum = 0;
			foreach (var a in expenses)
			{
				foreach (var b in expenses)
				{
					foreach (var c in expenses)
					{
						if (a + b + c == 2020) return sum + (a * b * c);
					}
				}
			}

			return sum;
		}
	}
}
