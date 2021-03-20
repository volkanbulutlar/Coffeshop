using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericsIntro
{
	class Program
	{
		static void Main(string[] args)
		{

			MyList<string> isimler = new MyList<string>();

			isimler.Add("volkan bulutlar");


			isimler.Add("seda bulutlar");


			isimler.Add("Melis Çakıl Bulutlar");



			foreach (var item in isimler.Items)
			{
				Console.WriteLine(item);
			}

		}
	}
}
