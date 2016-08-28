using System;
using System.Collections.Generic;

namespace PersonalMentoring {
	internal class If {
		private static void CommentedMain(string[] args) {
			NumsBelow1000();
			WordsBetweenDuckbills("Let's <one> word, <two> word and <the> rest.");
			new Triangle();
			Console.ReadKey();
		}

		private static void NumsBelow1000()
		{
			var result = new List<int>();
			for (var i = 1; i <= 1000; i++)
			{
				if (i%3 == 0 && i%5 == 0) result.Add(i);
			}
			foreach (var num in result)
			{
				Console.Write(num + ", ");
			}
			Console.WriteLine();
		}

		private static void WordsBetweenDuckbills(string sentence) {
			var result = new List<string>();
			var i = 0;

			while (sentence.Contains("<") && sentence.Contains(">")) {
				var startIndex = sentence.IndexOf('<');
				var endIndex = sentence.IndexOf('>');
				result.Add(sentence.Substring(startIndex + 1, endIndex - startIndex - 1));
				sentence = sentence.Substring(endIndex + 1);
				i++;
			}
			foreach (var word in result) Console.WriteLine(word);
		}

		private class Triangle {
			private double _a, _b, _c;

			internal Triangle() {
				GetResult();
			}

			private void GetResult() {
				GetSide("A", out _a);
				GetSide("B", out _b);
				GetSide("C", out _c);
				if (Equals(_c*_c, _a*_a + _b*_b) ||
					Equals(_a*_a, _b*_b + _c*_c) ||
					Equals(_b*_b, _a*_a + _c*_c)) {
					Console.WriteLine("It IS a right-angled triangle!");
				} else {
					Console.WriteLine("It is NOT a rigth-andlged triangle!");
				}
			}

			private void GetSide(string sideName, out double varName) {
				Console.Write($"Length of side {sideName} is: ");
				while (!double.TryParse(Console.ReadLine(), out varName)) {
					Console.WriteLine("Only natural numbers are accepted!");
					Console.Write("Length of side 'a' is: ");
				}
			}
		}
	}
}