using System;

namespace Day4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the DAY 4!");
			Console.WriteLine("");
			Console.WriteLine("Started reading input...");
			var startInput = 271973;
			var endInput = 785961;
			var correctCounter = 0;
			for (var i = startInput; i <= endInput; i++)
			{
				var doubleDigit = false;
				var neverDecrease = true;
				var lastNumber = 0;
				var seperateNumbers = i.ToString().ToCharArray();
				foreach (var number in seperateNumbers)
				{
					var n = Convert.ToInt32(number);
					if (lastNumber == n)
						doubleDigit = true;

					if (n < lastNumber)
						neverDecrease = false;

					lastNumber = n;
				}

				if (doubleDigit && neverDecrease)
					correctCounter++;
			}

			Console.WriteLine(correctCounter);
		}
	}
}
