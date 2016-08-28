using System;
using System.Text;

namespace PersonalMentoring {
	internal class String {
		public static void CommentedMain(string[] args) {
			SpacesBetweenChars("Put some space in this one.");
			PrintNameVertically("Atilla");
			Console.ReadKey();
		}

		private static void SpacesBetweenChars(string sentence) {
			var sb = new StringBuilder();
			foreach (var c in sentence) {
				sb.AppendFormat(c + " ");
			}
			Console.WriteLine(sb);
		}

		private static void PrintNameVertically(string name) {
			var sb = new StringBuilder();
		}
	}
}