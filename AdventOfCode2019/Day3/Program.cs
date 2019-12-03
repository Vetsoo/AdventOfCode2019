using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Day3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the DAY 3!");
			Console.WriteLine("");
			Console.WriteLine("Started reading input...");
			var wiresDirections = System.IO.File.ReadAllLines(@"Input/input.txt");
			var wire1Directions = wiresDirections[0].Split(',');
			var wire2Directions = wiresDirections[1].Split(',');
			var wire1Points = new List<Point>() { new Point(0, 0) };
			var wire2Points = new List<Point>() { new Point(0, 0) };

			foreach (var direction in wire1Directions)
			{
				var lastPoint = wire1Points.Last();
				var action = direction.Substring(0, 1);
				var number = Convert.ToInt32(direction.Substring(1));
				for (var i = 0; i < number; i++)
				{
					if (action == "R")
					{
						wire1Points.Add(new Point(lastPoint.X + 1, lastPoint.Y));
					}
					else if (action == "L")
					{
						wire1Points.Add(new Point(lastPoint.X - 1, lastPoint.Y));
					}
					else if (action == "U")
					{
						wire1Points.Add(new Point(lastPoint.X, lastPoint.Y + 1));
					}
					else if (action == "D")
					{
						wire1Points.Add(new Point(lastPoint.X, lastPoint.Y - 1));
					}
					lastPoint = wire1Points.Last();
				}
			}

			foreach (var direction in wire2Directions)
			{
				var lastPoint = wire2Points.Last();
				var action = direction.Substring(0, 1);
				var number = Convert.ToInt32(direction.Substring(1));
				for (var i = 0; i < number; i++)
				{
					if (action == "R")
					{
						wire2Points.Add(new Point(lastPoint.X + 1, lastPoint.Y));
					}
					else if (action == "L")
					{
						wire2Points.Add(new Point(lastPoint.X - 1, lastPoint.Y));
					}
					else if (action == "U")
					{
						wire2Points.Add(new Point(lastPoint.X, lastPoint.Y + 1));
					}
					else if (action == "D")
					{
						wire2Points.Add(new Point(lastPoint.X, lastPoint.Y - 1));
					}
					lastPoint = wire2Points.Last();
				}
			}

			var intersections = wire1Points.Intersect(wire2Points);
			var manhattanDistances = intersections.Select(d => d.X + d.Y).OrderBy(f => f);
			foreach (var distance in manhattanDistances)
			{
				Console.WriteLine(distance);
			}

			Console.WriteLine("-----------------------------------------------");

			var signalDelay = new List<int>();
			foreach (var intersection in intersections)
			{
				var wire1Steps = 0;
				var wire2Steps = 0;
				foreach (var wire1Point in wire1Points)
				{
					if (wire1Point.X == intersection.X && wire1Point.Y == intersection.Y)
						break;
					wire1Steps++;
				}
				foreach (var wire2Point in wire2Points)
				{
					if (wire2Point.X == intersection.X && wire2Point.Y == intersection.Y)
						break;
					wire2Steps++;
				}
				signalDelay.Add(wire1Steps + wire2Steps);
			}

			var orderedSignalDelay = signalDelay.OrderBy(f => f);
			foreach (var sd in orderedSignalDelay)
			{
				Console.WriteLine(sd);
			}

			Console.ReadLine();
		}
	}
}
