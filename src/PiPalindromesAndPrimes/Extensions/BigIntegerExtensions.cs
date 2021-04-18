using System;
using System.Numerics;

namespace PiPalindromesAndPrimes.Extensions
{
	/// <summary>
	/// Lifted from:
	/// http://stackoverflow.com/questions/3432412/calculate-square-root-of-a-biginteger-system-numerics-biginteger
	/// </summary>
	public static class BigIntegerExtensions
	{
		public static BigInteger SquareRoot(this BigInteger self)
		{
			static bool IsSquareRoot(BigInteger n, BigInteger root)
			{
				var lowerBound = root * root;
				var upperBound = (root + 1) * (root + 1);

				return (n >= lowerBound && n < upperBound);
			}

			if (self == 0) return 0;

			if (self > 0)
			{
				var bitLength = Convert.ToInt32(
					Math.Ceiling(BigInteger.Log(self, 2)));
				var root = BigInteger.One << (bitLength / 2);

				while (!IsSquareRoot(self, root))
				{
					root += self / root;
					root /= 2;
				}

				return root;
			}

			throw new ArithmeticException("NaN");
		}
	}
}