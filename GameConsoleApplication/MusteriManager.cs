using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleApplication
{
	class MusteriManager : IMusteriManager
	{
		
		
		public void Ekle(List<Musteri> musteriManagers)
		{
			foreach (var item in musteriManagers)
			{
			
					Console.WriteLine(item.Ad  + " Müşteri Eklendi.");
							
			}

			
		}

		public void Guncelle(List<Musteri> musteriManagers)
		{
			foreach (var item in musteriManagers)
			{
				Console.WriteLine(item.Ad  +  " Müşteri Güncellendi.");
			}

		}

		public void Sil(List<Musteri> musteriManagers)
		{
			foreach (var item in musteriManagers)
			{
				Console.WriteLine(item.Ad + " Müşteri Silindi");
			}
			
		}
	}
}
