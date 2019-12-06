using System;
using System.Linq;

namespace Day5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the DAY 5!");
			Console.WriteLine("");
			Console.WriteLine("Which system do you want to test?");
			var input = Console.ReadLine();
			Console.WriteLine("Started reading input...");
			var intCodeInput = System.IO.File.ReadAllText(@"Input/input.txt");
			var intCodeNumbers = intCodeInput.Split(',');
			var step = 0;
			var code = intCodeNumbers[step];
			var codeList = code.ToCharArray();
			var intCode = Convert.ToInt32(Convert.ToString(codeList.Last()));
			while (intCode != 9)
			{
				if (intCode == 5)
				{
					var lengthOfArray = codeList.Length;
					var param1 = Convert.ToInt32(intCodeNumbers[step + 1]);
					var param2 = Convert.ToInt32(intCodeNumbers[step + 2]);

					if (lengthOfArray < 3 || Convert.ToInt32(Convert.ToString(codeList[lengthOfArray - 3])) == 0)
						param1 = Convert.ToInt32(intCodeNumbers[param1]);

					if (lengthOfArray < 4 || Convert.ToInt32(Convert.ToString(codeList[lengthOfArray - 4])) == 0)
						param2 = Convert.ToInt32(intCodeNumbers[param2]);

					if (param1 != 0)
						step = param2;
					else
						step += 3;
				}
				if (intCode == 6)
				{
					var lengthOfArray = codeList.Length;
					var param1 = Convert.ToInt32(intCodeNumbers[step + 1]);
					var param2 = Convert.ToInt32(intCodeNumbers[step + 2]);

					if (lengthOfArray < 3 || Convert.ToInt32(Convert.ToString(codeList[lengthOfArray - 3])) == 0)
						param1 = Convert.ToInt32(intCodeNumbers[param1]);

					if (lengthOfArray < 4 || Convert.ToInt32(Convert.ToString(codeList[lengthOfArray - 4])) == 0)
						param2 = Convert.ToInt32(intCodeNumbers[param2]);

					if (param1 == 0)
						step = param2;
					else
						step += 3;
				}
				if (intCode == 7)
				{
					var lengthOfArray = codeList.Length;
					var param1 = Convert.ToInt32(intCodeNumbers[step + 1]);
					var param2 = Convert.ToInt32(intCodeNumbers[step + 2]);
					var param3 = Convert.ToInt32(intCodeNumbers[step + 3]);

					if (lengthOfArray < 3 || Convert.ToInt32(Convert.ToString(codeList[lengthOfArray - 3])) == 0)
						param1 = Convert.ToInt32(intCodeNumbers[param1]);

					if (lengthOfArray < 4 || Convert.ToInt32(Convert.ToString(codeList[lengthOfArray - 4])) == 0)
						param2 = Convert.ToInt32(intCodeNumbers[param2]);

					if (param1 < param2)
						intCodeNumbers[param3] = 1.ToString();
					else
						intCodeNumbers[param3] = 0.ToString(); 
					step += 4;
				}
				if (intCode == 8)
				{
					var lengthOfArray = codeList.Length;
					var param1 = Convert.ToInt32(intCodeNumbers[step + 1]);
					var param2 = Convert.ToInt32(intCodeNumbers[step + 2]);
					var param3 = Convert.ToInt32(intCodeNumbers[step + 3]);

					if (lengthOfArray < 3 || Convert.ToInt32(Convert.ToString(codeList[lengthOfArray - 3])) == 0)
						param1 = Convert.ToInt32(intCodeNumbers[param1]);

					if (lengthOfArray < 4 || Convert.ToInt32(Convert.ToString(codeList[lengthOfArray - 4])) == 0)
						param2 = Convert.ToInt32(intCodeNumbers[param2]);

					if (param1 == param2)
						intCodeNumbers[param3] = 1.ToString();
					else
						intCodeNumbers[param3] = 0.ToString();
					step += 4;
				}
				if (intCode == 1)
				{
					var lengthOfArray = codeList.Length;
					var param1 = Convert.ToInt32(intCodeNumbers[step + 1]);
					var param2 = Convert.ToInt32(intCodeNumbers[step + 2]);
					var param3 = Convert.ToInt32(intCodeNumbers[step + 3]);
					if (lengthOfArray < 3 || Convert.ToInt32(Convert.ToString(codeList[lengthOfArray - 3])) == 0)
						param1 = Convert.ToInt32(intCodeNumbers[param1]);

					if (lengthOfArray < 4 || Convert.ToInt32(Convert.ToString(codeList[lengthOfArray - 4])) == 0)
						param2 = Convert.ToInt32(intCodeNumbers[param2]);

					//if (lengthOfArray <= 5 || Convert.ToInt32(Convert.ToString(codeList[lengthOfArray - 5])) == 0)
					//	param3 = step + 3;

					intCodeNumbers[param3] = (param1 + param2).ToString();
					step += 4;
				}
				if (intCode == 2)
				{
					var lengthOfArray = codeList.Length;
					var param1 = Convert.ToInt32(intCodeNumbers[step + 1]);
					var param2 = Convert.ToInt32(intCodeNumbers[step + 2]);
					var param3 = Convert.ToInt32(intCodeNumbers[step + 3]);
					if (lengthOfArray < 3 || Convert.ToInt32(Convert.ToString(codeList[lengthOfArray - 3])) == 0)
						param1 = Convert.ToInt32(intCodeNumbers[param1]);

					if (lengthOfArray < 4 || Convert.ToInt32(Convert.ToString(codeList[lengthOfArray - 4])) == 0)
						param2 = Convert.ToInt32(intCodeNumbers[param2]);

					//if (lengthOfArray <= 5 || Convert.ToInt32(Convert.ToString(codeList[lengthOfArray - 5])) == 0)
					//	param3 = step + 3;

					intCodeNumbers[param3] = (param1 * param2).ToString();
					step += 4;
				}
				if (intCode == 3)
				{
					intCodeNumbers[Convert.ToInt32(intCodeNumbers[step + 1])] = input;
					step += 2;
				}
				if (intCode == 4)
				{
					if (Convert.ToInt32(Convert.ToString(codeList[0])) == 1)
						Console.WriteLine(Convert.ToInt32(intCodeNumbers[step + 1]));
					else
						Console.WriteLine(intCodeNumbers[Convert.ToInt32(intCodeNumbers[step + 1])]);
					step += 2;
				}
				codeList = intCodeNumbers[step].ToCharArray();
				intCode = Convert.ToInt32(Convert.ToString(codeList.Last()));
			}
			Console.ReadLine();
		}
	}
}
