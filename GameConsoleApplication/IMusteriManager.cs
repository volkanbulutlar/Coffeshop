using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleApplication
{
	interface IMusteriManager
	{

		void Ekle(List<Musteri> musteriManagers);
		void Guncelle(List<Musteri> musteriManagers);
		void Sil(List<Musteri> musteriManagers);
		
	}
}
