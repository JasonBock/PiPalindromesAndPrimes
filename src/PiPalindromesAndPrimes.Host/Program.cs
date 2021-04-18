using PiPalindromesAndPrimes;
using Spackle.Extensions;
using System;

for (var i = 3u; i < 14u; i++)
{
	Console.Out.WriteLine(new Action(() =>
	{
		var (number, position, isPrimePalindrome) = FirstPalindromeInPiFinder.Find(i);

		if (isPrimePalindrome)
		{
			Console.Out.WriteLine($"Size: {i} - Result: {number} - Position: {position}");
		}
		else
		{
			Console.Out.WriteLine($"Size: {i} - no palindrome found");
		}
	}).Time());
}