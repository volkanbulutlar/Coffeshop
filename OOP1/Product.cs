using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
	class Product
	{
		//Unique Id
		public int Id { get; set; }
		//Urun Adı
		public string ProductName { get; set; }
		//Urunun Fiyati
		public double UnitPrice { get; set; }
		//Hangi Kategoriye Ait
		public int CategoryId { get; set; }
		//Stok Adedi 		
		public int UnitsInStock { get; set; }

		// CRUD İşlemleri
	}
}