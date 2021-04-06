using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{

	//İş sınıflarıdır. Business Class            
	class CustomerManager
	{
		public void Add(Musteri musteri)
		{

			Console.WriteLine(musteri.CustomerNum + " " +  "eklendi.");

		}

	}
}
