using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClassType
{
	class Customer
	{

		public Customer(int id,string adi,string soyadi,string tckimlikno)
		{
			Id = id;
			Adı = adi;
			Soyadı = soyadi;
			TcKimlikNo = tckimlikno;

		}

		public int Id { get; set; }
		public string Adı { get; set; }
		public string Soyadı { get; set; }
		public string TcKimlikNo { get; set; }


	}
}
