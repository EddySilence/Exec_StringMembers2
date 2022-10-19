using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//題目：比對使用者輸入值是否為 "Allen" 不拘大小寫
			String correctPw = "Allen";
			Console.WriteLine("請輸入名字，不拘大小寫");
			String input = Console.ReadLine();

			correctPw = correctPw.ToLower();
			input = input.ToLower();

			if (input == correctPw)
			{
				Console.WriteLine("輸入正確");
			}
			else
			{
				Console.WriteLine("輸入錯誤");
			}

		}
	}
}
