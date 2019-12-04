using System;
using System.Linq;

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
				var thirdToLastNumber = 0;
				var secondToLastNumber = 0;
				var seperateNumbers = i.ToString().ToCharArray();
				var counter = 1;
				foreach (var number in seperateNumbers)
				{
					var n = Convert.ToInt32(number);
					if (lastNumber == secondToLastNumber && lastNumber != thirdToLastNumber && lastNumber != n)
						doubleDigit = true;

					if (n < lastNumber)
						neverDecrease = false;

					if (counter == 6 && n == lastNumber && n != secondToLastNumber)
						doubleDigit = true;

					thirdToLastNumber = secondToLastNumber;
					secondToLastNumber = lastNumber;
					lastNumber = n;
					counter++;
				}

				if (doubleDigit && neverDecrease)
					correctCounter++;
			}

			Console.WriteLine(correctCounter);
		}
	}
}
