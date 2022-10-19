using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//題目：將字串 "aLLeN kUO" 轉換成 "Allen Kuo"

			String input = "aLLeN kUO";
			input = input.ToLower();
			String[] strings = input.Split(' ');

			String firstName = strings[0].Substring(0, 1).ToUpper() + strings[0].Substring(1, strings[0].Length - 1);

			String lastName = strings[1].Substring(0, 1).ToUpper() + strings[1].Substring(1, strings[1].Length - 1);

			Console.WriteLine($"{firstName} {lastName}");
		}
	}
}
