using System;
using System.Collections.Generic;

namespace GameConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			IMusteriManager musteri = new MusteriManager();
						
			MusteriKayit musteriKayit = new MusteriKayit();


			List<Musteri> musteriManagers = new List<Musteri>() { new Musteri() { Id = 1, Ad = "Volkan", Soyad = "Bulutlar", TcNo = "1231231", DogumYılı = "123131", Musteri_No = "123131" ,DogumTarih="12313131"} };
			musteriKayit.MusteriKaydet(musteriManagers);


			musteriKayit.MusteriSil(musteriManagers);

		}
	}
}
