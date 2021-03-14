using System;

namespace Coffeshop
{
	class Program
	{
		static void Main(string[] args)
		{

			//string array diziler
			
			//string[] kurslar = new string[] {"Yazilim geliştirici yetistirici kampi ","Programlama ","Tasarım","Phyton","C++"};

			/*for (int i =0 ; i < kurslar.Length; i++)
			{
				Console.WriteLine(/kurslar[i]);
			}*/


		/*	yalnızca dizilere uygulanır foreach (string xyz in kurslar)

			{
				Console.WriteLine(xyz);
			}
		*/

			Kurs Kurs1 = new Kurs();

			Kurs1.KursAdi = "C#";
			Kurs1.Egitmen = "Volkan Bulutlar";
			Kurs1.IzlenmeOrani = 80;



			Kurs Kurs2 = new Kurs();

			Kurs2.KursAdi = "Java";
			Kurs2.Egitmen = "Seda";
			Kurs2.IzlenmeOrani = 60;


			Console.WriteLine("KursAdi:" + Kurs2.KursAdi + " " + " Eğitmen:" + Kurs2.Egitmen);
			Console.WriteLine("KursAdi:" + Kurs1.KursAdi + " " + " Eğitmen:" + Kurs1.Egitmen);


			Kurs[] kurslar = new Kurs[] {Kurs1,Kurs2};


			foreach (Kurs kurs in kurslar)
			{
				Console.WriteLine(kurs.KursAdi + " : "  + kurs.Egitmen);
			}


			Product Urun1 = new Product();

			Urun1.UrunAdi = "Philips";

			Product[] Urunler = new Product[] { Urun1 };

			foreach (Product urun in Urunler)
			{
				Console.WriteLine(urun.UrunAdi);
			}
		}

		class Kurs
		{
			public string KursAdi { get; set; }

			public string Egitmen { get; set; }

			public int IzlenmeOrani { get; set; }


		}



		class Product
		{
			public string UrunAdi { get; set; }

			public string Markasi { get; set; }

			public string Modeli { get; set; }

			public int Fiyati { get; set; }


		}
	}
}
