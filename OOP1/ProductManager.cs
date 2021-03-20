using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
	class ProductManager
	{

		// Encapsulation  (Her bir parametre için product class'ının propertylerine erişebilmek için nesne olarak gönderiyoruz)
		public void Add(Product product)
		{
			Console.WriteLine(product.ProductName + " Eklendi");


		}


		public void Update ( Product product)
		{

			Console.WriteLine(product.ProductName + " Güncellendi");
		}


	}
}
