using NUnit.Framework;
using PiPalindromesAndPrimes.Extensions;
using System;
using System.Numerics;

namespace PiPalindromesAndPrimes.Tests
{
	public static class BigIntegerExtensionTests
	{
		[Test]
		public static void CalculateSquareRoot()
		{
			var number = new BigInteger(1095222947842);
			Assert.That(new BigInteger(1046529), Is.EqualTo(number.SquareRoot()));
		}

		[Test]
		public static void CalculateSquareRootWhenInputIsNegative() => 
			Assert.That(() => new BigInteger(-1).SquareRoot(), Throws.TypeOf<ArithmeticException>());

		[Test]
		public static void CalculateSquareRootWhenInputIsZero() => 
			Assert.That(BigInteger.Zero, Is.EqualTo(BigInteger.Zero.SquareRoot()));
	}
}