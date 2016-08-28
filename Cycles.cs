using System;
using System.Collections.Generic;

namespace PersonalMentoring{
	internal class Cycles {
		public static void CommmentedMain(string[] args) {
			SumNumsFrom1To100();
			MultiplyNumsFrom1To7();
			SumEvenNumsFrom1To100();
			SumOddNumsFrom1To100();
			PrintStars(4);
			PrintRectangle(9, 4);
			PrintFibonacciSeries(6);
			SumFibonacciSeries(6);
			Factorial(5);
			Console.ReadKey();
		}

		private static void SumNumsFrom1To100() {
			var sum = 0;
			for (var i = 1; i < 101; i++) {
				sum += i;
			}
			Console.WriteLine("The nums summmed from 1 to 100 is: " + sum);
		}

		private static void MultiplyNumsFrom1To7()
		{
			var sum = 1;
			for (var i = 1; i < 8; i++)
			{
				sum *= i;
			}
			Console.WriteLine("The nums multiplyed from 1 to 7 is: " + sum);
		}

		private static void SumEvenNumsFrom1To100()
		{
			var sum = 0;
			for (var i = 2; i < 101; i += 2)
			{
				sum += i;
			}
			Console.WriteLine("The even nums summed from 1 to 100 is: " + sum);
		}

		private static void SumOddNumsFrom1To100()
		{
			var sum = 0;
			for (var i = 1; i < 101; i += 2)
			{
				sum += i;
			}
			Console.WriteLine("The odd nums summed from 1 to 100 is: " + sum);
		}

		private static void PrintStars(int num) {
			for (var i = 1; i < num + 1; i++) {
				Console.Write(new string('*', i));
				Console.WriteLine();
			}
		}

		private static void PrintRectangle(int width, int heigth) {
			Console.WriteLine (new string('*', width));
			for (var i = 0; i < heigth; i++) {
				Console.Write("*" + new string(' ', width - 2) + "*" + "\n");
			}
			Console.WriteLine (new string('*', width));
		}

		private static void PrintFibonacciSeries(int members) {
			var result = new List<int> {1, 1};
			for (var i = 2; i <= members; i++) {
				result.Add(result[i - 1] + result[i - 2]);
			}
			foreach (var item in result) {
				Console.Write(item + ", ");
			}
			Console.WriteLine();
		}

		private static void SumFibonacciSeries(int members) {
			var series = new List<int> {1, 1};
			var result = 0;
			for (var i = 2; i <= members; i++) {
				series.Add(series[i - 1] + series[i - 2]);
			}
			foreach (var item in series) {
				result += item;
			}
			Console.WriteLine(result);
		}

		private static void Factorial(int num) {
			var sum = 1;
			for (var i = 1; i <= num; i++ ) {
				sum *= i;
			}
			Console.WriteLine(sum);
		}
	}
}