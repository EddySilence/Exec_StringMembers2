using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//題目：隱藏手機的資訊　呈現 0935****46

			String phoneNumber = "0935270146";

			String result = phoneNumber.Substring(0, 4) + new String('*', 4) + phoneNumber.Substring(8, 2);
			Console.WriteLine(result);

		}
	}
}
