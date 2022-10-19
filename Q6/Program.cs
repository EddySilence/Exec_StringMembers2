using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//比對使用者輸入值是否為 "Allen", 區分大小寫
			String correctPw = "Allen";
			Console.WriteLine("請輸入名字，區分大小寫");
			String input = Console.ReadLine();

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
