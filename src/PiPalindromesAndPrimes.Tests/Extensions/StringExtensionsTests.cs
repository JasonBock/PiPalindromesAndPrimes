using NUnit.Framework;
using PiPalindromesAndPrimes.Extensions;

namespace PiPalindromesAndPrimes.Tests
{
	public static class StringExtensionsTests
	{
		[Test]
		public static void CallIsPalindromeWhenStringIsNull() => 
			Assert.That((null as string).IsPalindrome(), Is.False);

		[Test]
		public static void CallIsPalindromeWhenStringIsPalindromeAndHasEvenLength() => 
			Assert.That("ymmy".IsPalindrome(), Is.True);

		[Test]
		public static void CallIsPalindromeWhenStringIsPalindromeAndHasOddLength() => 
			Assert.That("ymxmy".IsPalindrome(), Is.True);

		[Test]
		public static void CallIsPrimeWhenValueIsLessThan2() => 
			Assert.That("1".IsPrime(), Is.False);

		[Test]
		public static void CallIsPrimeWhenValueIsPrime() => 
			Assert.That("1073676287".IsPrime(), Is.True);

		[Test]
		public static void CallIsPrimeWhenValueIsNotANumber() => 
			Assert.That("x".IsPrime(), Is.False);

		[Test]
		public static void CallIsPrimeWhenValueIsNotPrimeAndEven() => 
			Assert.That("1048576".IsPrime(), Is.False);

		[Test]
		public static void CallIsPrimeWhenValueIsNotPrimeAndNotEven() => 
			Assert.That("1111088889".IsPrime(), Is.False);
	}
}
