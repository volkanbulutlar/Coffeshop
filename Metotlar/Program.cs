using System;

namespace Metotlar
{
	class Program
	{
		static void Main(string[] args)
		{

		
			Urun urun1 = new Urun();

			urun1.Adi = "Telefon";
			urun1.Fiyati = 10;



			Urun urun2= new Urun();

			urun2.Adi = "Televizyon";
			urun2.Fiyati = 5;
			urun2.StokAdedi = 6;

			Urun[] urunler = new Urun[] { urun1 ,urun2};

			foreach (Urun urun in urunler)
			{
				Console.WriteLine(urun.Adi);
				Console.WriteLine(urun.Fiyati);
				Console.WriteLine("-----------------");
			}

			Console.WriteLine("-----------Metotlar-----");

			SepetManager sepetmanager = new SepetManager();
			sepetmanager.Ekle(urun1);
			sepetmanager.Ekle(urun2);
		}
	}
}
