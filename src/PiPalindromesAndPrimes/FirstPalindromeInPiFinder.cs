using PiPalindromesAndPrimes.Extensions;

namespace PiPalindromesAndPrimes
{
	public static class FirstPalindromeInPiFinder
	{
		public static (string number, long position, bool isPalindromePrime) Find(uint length)
		{
			foreach (var (number, position) in NumberGenerator.Generate(length))
			{
				if (number.IsPalindrome() && number.IsPrime())
				{
					return (number, position, true);
				}
			}

			return (string.Empty, 0, false);
		}
	}
}