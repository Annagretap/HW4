using System;

namespace Homework4
{
	class Program
	{
		static void Main(string[] args)
		{
			//hw1

			//int[] luckyNumbers = { 4, 8, 2, 3};
			//int sum = 0;
			//foreach (var i in luckyNumbers)
			//{
			//sum += i;
			//}
			//Console.WriteLine(sum);
			//Console.ReadLine();

			//hw2

			int[] luckyNumbers = { 1, 2, 3, 55, 44, 36, 87, 50, 30, 15 };
			foreach (int result in luckyNumbers)

			{
				Array.Sort(luckyNumbers);
				if (result % 2 == 0)

				{
					Console.WriteLine(result + "is Even Number");
				}
				else
				{
					Console.WriteLine(result + "is Odd Number");
				}
			}

			Console.ReadLine();
			
			
			
			
			
			
			
			
			
			
			
			
			//hw (opt2)

			
			//for (int i = 1; i < 5; i++)
			//{
				//Console.WriteLine("C# For Loop: Iteration " + i);
			//}

			//Console.ReadLine();

			


			
			//training

			//int[] arr = new int[] { 1, 2, 3 };
			//int sum = 0;
			//for (int i = 0; i < arr.Length; i++)
			//{
				//sum += arr[i];
			//}
			//Console.ReadLine()

			//3
			//int[] luckyNumbers = { 4, 8, 2, 3 };
			//foreach (int item in luckyNumbers)
			//{
			//Console.WriteLine(item);
			//Console.ReadLine();

			//4
			//int[] myArray = int[3];

			//myArray[0] = 5;
			//myArray[1] = 6;
			//myArray[2] = 7;

			//Console.WriteLine(myArray[0]);
			//Console.ReadLine();

			

		}
	}
}
