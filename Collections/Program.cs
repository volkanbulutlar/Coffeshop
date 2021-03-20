using System;
using System.Collections.Generic;

namespace Collections
{
	class Program
	{
		static void Main(string[] args)
		{
			//string[] isimler = new string[] { "Engin", "Volkan" };

			//Console.WriteLine(isimler[0] + " " + isimler[1]);


			List<string> isimler2 = new List<string>() {"Volkan","Engin" };

			Console.WriteLine(isimler2[0]);
			Console.WriteLine(isimler2[1]);
			isimler2.Add("İlker");
			Console.WriteLine(isimler2[2]);
			Console.WriteLine(isimler2[0]);


		}
	}
}
