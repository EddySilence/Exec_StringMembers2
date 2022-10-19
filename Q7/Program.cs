using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//題目：計算兩數之和,並只呈現小數二位數

			double number1 = 17.2353;
			double number2 = 18.2364;

			double result = number1 + number2;

			String resultString = String.Empty;
			resultString = result.ToString(".##");

			Console.WriteLine(resultString);

		}
	}
}
