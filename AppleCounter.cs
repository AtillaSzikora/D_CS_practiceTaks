using System;

namespace PersonalMentoring {
	public class Variables {
		public static void AppleCounter() {
			int applePrice;
			int appleQuantity;

			Console.Write("How much is the apple: ");
			while (!int.TryParse(Console.ReadLine(), out applePrice)) {
				Console.WriteLine("Please give a number!");
				Console.Write("How much is the apple: ");
			}

			Console.Write("How many apple would you like: ");
			while (!int.TryParse(Console.ReadLine(), out appleQuantity)) {
				Console.WriteLine("Please give a number!");
				Console.Write("How many apple would you like: ");
			}

			Console.WriteLine("It will cost you: " + applePrice * appleQuantity);
			Console.ReadKey();
		}
	}
}
