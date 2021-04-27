using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleApplication
{
	interface IMusteriManager 
	{

		void Ekle(Musteri musteri);
		void Guncelle(Musteri musteri);
		void Sil(Musteri musteri);
		
	}
}
