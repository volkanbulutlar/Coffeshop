using System;

namespace OOP3
{
	class Program
	{
		static void Main(string[] args)
		{

			//SOLID MANTIĞI

			//Bireysel Müşteri 

			IndividualCustomer musteri1 = new IndividualCustomer();

			musteri1.Id = 123;
			musteri1.CustomerNum = "12345";
			musteri1.CustomerName = "Volkan";
			musteri1.CustomerLastName = "Bulutlar";
			musteri1.TcNo = "1231412313131";




			//Tüzel Müşteri

			CorporateCustomer musteri2 = new CorporateCustomer();
			musteri2.Id = 1234;
			musteri2.CustomerNum = "123456";
			musteri2.SirketAdi = "Gravel.io";
			musteri2.VergiNo = "123451231";


			Musteri musteri3 = new IndividualCustomer();
			Musteri musteri4 = new CorporateCustomer();

			CustomerManager customerManager = new CustomerManager();

			customerManager.Add(musteri1);
			customerManager.Add(musteri2);








		}
	}
}
