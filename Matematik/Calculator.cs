using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
	class Calculator
	{
		public void Topla(int sayi1,int sayi2)
		{
			int toplam = sayi1 + sayi2;
			Console.WriteLine("Sonuç : " + toplam);

		}

		public void Cikar(int sayi1,int sayi2 )
		{
			int toplam = sayi1 - sayi2;
			Console.WriteLine("Sonuç :" + toplam);
		}

	}
}
