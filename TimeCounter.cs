using System;

namespace PersonalMentoring {
	internal class TimeCounter {
		private static TimeSpan _time1, _time2;
		private static int _time1H, _time1M, _time1S, _time2H, _time2M, _time2S;

		private static void CommentedMain(string[] args) {
			_time1 = SetTime(out _time1H, out _time1M, out _time1S);
			_time2 = SetTime(out _time2H, out _time2M, out _time2S);
			Console.WriteLine("Time difference in seconds: " + (_time1 -_time2).TotalSeconds);
			Console.ReadKey();
		}

		private static TimeSpan SetTime(out int timeH, out int timeM, out int timeS) {
			GetTime("hour", 23, out timeH);
			GetTime("minute", 59, out timeM);
			GetTime("second", 59, out timeS);
			return new TimeSpan(timeH, timeM, timeS);
		}

		private static void GetTime (string timeName, int upperLimit, out int varName) {
			Console.Write($"Your {timeName} is: ");
			while (!(int.TryParse(Console.ReadLine(), out varName) && varName >= 0 && varName <= upperLimit)) {
				Console.WriteLine($"Please use a whole number between 0 and {upperLimit}");
				Console.Write($"Your {timeName} is: ");
			}
		}
	}
}