using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleApplication
{
	class MusteriManager : IMusteriManager
	{
		IUserValidationService _userValidationService;
		

		public MusteriManager(IUserValidationService userValidationService)
		{

			_userValidationService = userValidationService;
		}

		

		public void Ekle(Musteri musteri)
		{
			if (_userValidationService.Validate(musteri) == true)
			{
				Console.WriteLine(musteri.Ad + " Müşteri Eklendi.");
			}
			else
			{
				Console.WriteLine(musteri.Ad + " Müşteri Bilgisi Hatalı Kayıt Eklenemedi.");
			}
			
		}

		public void Guncelle(Musteri musteri)
		{
			if (_userValidationService.Validate(musteri) == true)
			{
				Console.WriteLine(musteri.Ad  +  " Müşteri Güncellendi.");
			} 
			else
			{
				Console.WriteLine(musteri.Ad + " Müşteri Bilgisi Hatalı Kayıt Güncellenemedi.");
			}
		}

		public void Sil(Musteri musteri)
		{

			if (_userValidationService.Validate(musteri) == true)
			{
				Console.WriteLine(musteri.Ad + " Müşteri Silindi.");
			}
			else
			{
				Console.WriteLine(musteri.Ad + " Müşteri Bilgisi Hatalı Kayıt Silinemedi.");
			}

		}
	}
}
