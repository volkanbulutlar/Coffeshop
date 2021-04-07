using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleApplication
{
	class MusteriKayit
	{
		public void MusteriKaydet(List<Musteri> musteriManagers)
		{
			foreach (var item in musteriManagers)
			{
				item.Ekle(musteriManagers);

			}

		}

		public void MusteriSil(List<Musteri> musteriManagers)
		{
			foreach (var item in musteriManagers)
			{
				item.Sil(musteriManagers);

			}

		}


	}
}
