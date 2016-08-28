using System;
using System.Collections.Generic;

namespace PersonalMentoring {
	internal class Bills {

		private static int GetMoney() {
			Console.Write("Give me a sum of money: ");
			var money = int.Parse(Console.ReadLine());
			return money;
		}

		private static List<int> BillCounter(int money) {
			int[] coins = {10, 5, 2, 1};
			var result = new List<int>();
			var i = 0;
			while (money > 0) {
				if (money >= coins[i]) {
					money -= coins[i];
					result.Add(coins[i]);
				} else {
					i++;
				}
			}
			return result;
		}

		private static void CommentedMain(string[] args) {
			var result = BillCounter(GetMoney());
			Console.Write("Result is: ");
			foreach (var item in result) {
				Console.Write(item + ", ");
			}
			Console.ReadKey();
		}
	}
}