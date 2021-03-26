using System;

namespace GenericClassType
{
	class Program
	{
		static void Main(string[] args)
		{
			CustomerManager<Customer> Musteriler = new CustomerManager<Customer>();

			Musteriler.Add(new Customer (1,"Volkan ","Bulutlar", "1231231414141"));

			Musteriler.Add(new Customer (2,"Seda ", "Bulutlar","1231212313131414141" ));

			foreach (var item in Musteriler.Items)
			{
				Console.WriteLine(item.Id + " " + item.Adı + " " + item.Soyadı + " "  + item.TcKimlikNo);
			}
		}
	}
}
