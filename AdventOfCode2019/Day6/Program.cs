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

			// find the orbits from YOU
			var you = directOrbitsDictionary.FirstOrDefault(f => f.Item2 == "YOU");
			var allYouOrbits = new List<Tuple<string, string>>() { you };
			while (you.Item1 != "COM")
			{
				var indirectOrbit = directOrbitsDictionary.First(o => o.Item2 == you.Item1);
				you = indirectOrbit;
				allYouOrbits.Add(you);
			}

			// find the orbits from SAN
			var san = directOrbitsDictionary.FirstOrDefault(f => f.Item2 == "SAN");
			var allSanOrbits = new List<Tuple<string, string>>() { san };
			while (san.Item1 != "COM")
			{
				var indirectOrbit = directOrbitsDictionary.First(o => o.Item2 == san.Item1);
				san = indirectOrbit;
				allSanOrbits.Add(san);
			}

			var notIncommonYou = allYouOrbits.Except(allSanOrbits);
			var notIncommonSan = allSanOrbits.Except(allYouOrbits);
			var notincommon = new List<Tuple<string, string>>();
			notincommon.AddRange(notIncommonYou);
			notincommon.AddRange(notIncommonSan);
			var planet = notincommon.Select(f => f.Item1).GroupBy(f => f).Where(f => f.Count() > 1).Select(f => f.Key).ToList();

			var youEnd = allYouOrbits.FirstOrDefault(f => f.Item1 == planet.FirstOrDefault());
			var sanEnd = allSanOrbits.FirstOrDefault(f => f.Item1 == planet.FirstOrDefault());

			// find the orbits from YOU
			you = directOrbitsDictionary.FirstOrDefault(f => f.Item2 == "YOU");
			var totalYouOrbits = 1;
			while (you.Item1 != youEnd.Item1)
			{
				var indirectOrbit = directOrbitsDictionary.First(o => o.Item2 == you.Item1);
				you = indirectOrbit;
				totalYouOrbits++;
			}

			// find the orbits from SAN
			san = directOrbitsDictionary.FirstOrDefault(f => f.Item2 == "SAN");
			var totalSanOrbits = 1;
			while (san.Item1 != youEnd.Item1)
			{
				var indirectOrbit = directOrbitsDictionary.First(o => o.Item2 == san.Item1);
				san = indirectOrbit;
				totalSanOrbits++;
			}
			Console.WriteLine(totalYouOrbits + totalSanOrbits - 2);
			Console.ReadLine();
		}
	}
}
