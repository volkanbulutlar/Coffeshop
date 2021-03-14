using System;

namespace Matematik
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculator sayilar = new Calculator();
			sayilar.Topla(5,6);

			sayilar.Topla(4, 5);

			sayilar.Cikar(10, 4);
		}
	}
}
