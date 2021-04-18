using Spackle.Extensions;
using System.Collections.Generic;
using System.IO;

namespace PiPalindromesAndPrimes
{
	public static class NumberGenerator
	{
		private const int BlockSize = 2048;

		public static IEnumerable<(string number, long position)> Generate(uint length)
		{
			var number = new char[length];
			var position = 0u;

			using var reader = new StreamReader(typeof(NumberGenerator).Assembly.GetManifestResourceStream("PiPalindromesAndPrimes.pi.txt")!);
			reader.ReadBlock(number, 0, (int)length);

			yield return (new string(number), position);

			position++;
			var newChar = new char[NumberGenerator.BlockSize];

			while (true)
			{
				if (reader.EndOfStream)
				{
					break;
				}
				else
				{
					var digitsRead = reader.ReadBlock(newChar, 0, NumberGenerator.BlockSize);

					for (var i = 0; i < digitsRead; i++)
					{
						number.Rotate(1, RotateDirection.Negative);
						number[length - 1] = newChar[i];
						yield return (new string(number), position);
						position++;
					}
				}
			}
		}
	}
}