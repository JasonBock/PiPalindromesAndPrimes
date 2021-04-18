using System.Numerics;

namespace PiPalindromesAndPrimes.Extensions
{
	public static class StringExtensions
	{
		public static bool IsPalindrome(this string self)
		{
			if (!string.IsNullOrWhiteSpace(self))
			{
				var length = self.Length;

				for (var i = 0; i < length / 2; i++)
				{
					if (self[i] != self[length - i - 1])
					{
						return false;
					}
				}

				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// My current implementation is very naive.
		/// What I should really do is this:
		/// http://teal.gmu.edu/courses/ECE746/project/F06_Project_resources/Salembier_Southerington_AKS.pdf
		/// </summary>
		public static bool IsPrime(this string self)
		{
			if (BigInteger.TryParse(self, out var value) && value > 2 && !value.IsEven)
			{
				for (var i = new BigInteger(3); i < value.SquareRoot(); i += 2)
				{
					if (BigInteger.Remainder(value, i) == BigInteger.Zero)
					{
						return false;
					}
				}

				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
