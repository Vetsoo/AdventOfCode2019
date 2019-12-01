using System;
using System.Collections.Generic;
using System.Linq;

namespace Day1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the DAY 1!");
			Console.WriteLine("");
			Console.WriteLine("Started reading input...");
			var modulesMass = System.IO.File.ReadAllLines(@"Input/input.txt");
			var fuelList = new List<double>();
			foreach (var module in modulesMass)
			{
				var fuelForModuleList = new List<double>();
				var fuel = Math.Floor((double)Convert.ToInt32(module) / 3) - 2;
				fuelForModuleList.Add(fuel);
				while (fuel > 5)
				{
					fuel = Math.Floor(fuel / 3) - 2;
					fuelForModuleList.Add(fuel);
				}
				fuelList.Add(fuelForModuleList.Sum());
			}

			var totalFuel = fuelList.Sum();
			Console.WriteLine(totalFuel);
			Console.ReadLine();
		}
	}
}
