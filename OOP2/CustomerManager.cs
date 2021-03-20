using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClassType
{
	class CustomerManager<Customer>
	{
		Customer[] customer;


		public CustomerManager()
		{
			customer = new Customer[0];
		}


		public void Add(Customer item)
		{
			Customer[] tempArray = customer;

			customer = new Customer[customer.Length + 1];

			for (int i = 0; i < tempArray.Length; i++)
			{
				customer[i] = tempArray[i];

			}

			customer[customer.Length - 1] = item;

		}


		public Customer[] Items
		{
			get { return customer; }
		}
	}
}
