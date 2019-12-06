using System;
using System.Collections.Generic;
using System.Linq;

namespace Day6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the DAY 6!");
			Console.WriteLine("");
			Console.WriteLine("Started reading input...");
			var directOrbits = System.IO.File.ReadAllLines(@"Input/input.txt");
			var directOrbitsDictionary = directOrbits.Select(f => { var split = f.Split(')'); return new Tuple<string, string>(split[0], split[1]); });

			var totalOrbitCounter = 0;
			foreach (var directOrbit in directOrbitsDictionary)
			{
				var placeholder = directOrbit;
				totalOrbitCounter++;
				while (placeholder.Item1 != "COM")
				{
					var indirectOrbit = directOrbitsDictionary.First(o => o.Item2 == placeholder.Item1);
					placeholder = indirectOrbit;
					totalOrbitCounter++;
				}
			}
			Console.WriteLine(totalOrbitCounter);
			Console.ReadLine();
		}
	}
}
