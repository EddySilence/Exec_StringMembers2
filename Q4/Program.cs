using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//題目：假設有表示日期的字串"1100225", 請將它轉成表示西元年的日期"20210225"
			String date = "1100225";

			int vids = Convert.ToInt32(date.Substring(0, 3));
			vids += 1911;

			String result = $"{vids}{date.Substring(3, 4)}";

			Console.WriteLine(result);

		}
	}
}
