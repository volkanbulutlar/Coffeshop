using System;

namespace GenericClassType
{
	class Program
	{
		static void Main(string[] args)
		{
			CustomerManager<Customer> Musteriler = new CustomerManager<Customer>();

			Musteriler.Add(new Customer { Id = 1, Adı = "Volkan ", Soyadı = "Bulutlar", TcKimlikNo = "1231231414141" });

			Musteriler.Add(new Customer { Id = 1, Adı = "seda ", Soyadı = "Bulutlar", TcKimlikNo = "1231212313131414141" });

			foreach (var item in Musteriler.Items)
			{
				Console.WriteLine(item.Id + " " + item.Adı + " " + item.Soyadı + " "  + item.TcKimlikNo);
			}
		}
	}
}
