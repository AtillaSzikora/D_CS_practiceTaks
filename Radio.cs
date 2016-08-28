using NUnit.Framework;

namespace PersonalMentoring {
	internal class Program {
		public static void Main(string[] args) {}
	}

	internal class Radio {
		private bool _isSwitchedOn;
		private int _volume;
		private double _frequency;

		public Radio() {
			_isSwitchedOn = true;
			_volume = 10;
			_frequency = 1605; }

		public bool SetVolume(int volume) {
			if (volume >= 0 && volume <= 10) {
				_volume = volume;
				return true;
			}
			return false; }

		public bool SetFrequency(int frequency) {
			if (frequency >= 535 && frequency <= 1605) {
				_frequency = frequency;
				return true;
			}
			return false; }
	}

	[TestFixture]
	internal class RadioTests {
		private readonly Radio _radio = new Radio();

		[Test]
		public void SetNegativeVolumeReturnsFalse() {
			Assert.IsFalse(_radio.SetVolume(-1)); }

		[Test]
		public void SetVolumeBiggerThan10ReturnsFalse() {
			Assert.IsFalse(_radio.SetVolume(11)); }

		[Test]
		public void SetVolumeBetween0And10ReturnsTrue() {
			Assert.IsTrue(_radio.SetVolume(5)); }

		[Test]
		public void SetVolumeSmallerThan535ReturnsFalse() {
			Assert.IsFalse(_radio.SetFrequency(534)); }

		[Test]
		public void SetFrequencyBiggerThan1605ReturnsFalse() {
			Assert.IsFalse(_radio.SetFrequency(1606)); }

		[Test]
		public void SetFrequencyBetween535And1605ReturnsTrue() {
			Assert.IsTrue(_radio.SetFrequency(1000)); }
	}
}