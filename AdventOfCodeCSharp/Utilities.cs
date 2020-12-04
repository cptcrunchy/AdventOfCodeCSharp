using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCodeCSharp
{
	class Utilities
	{
		public static List<string> ReadFile(int day, string fileName)
		{
			string dayDirectory = (day < 10) ? string.Concat("0", day) : day.ToString();
			string filePath = $"day-{dayDirectory}/{fileName}";
			List<string> lines = File.ReadAllLines(filePath).ToList();

			return lines;
		}
	}
}
