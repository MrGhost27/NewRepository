using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Helper
{
	static class Helper
	{
		private static Random random = new Random();

		internal static int GenerateRandomNumber(int min, int max)
		{
			int randomNumber = random.Next(min, max);
			return randomNumber;
		}
	}
}
