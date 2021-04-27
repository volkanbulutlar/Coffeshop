using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleApplication
{
	class UserValidationManager : IUserValidationService
	{
		
			public bool Validate(Musteri musteri)
			{
			if (musteri.Ad == "Volkan" && musteri.Soyad == "Bulutlar" && musteri.DogumYılı=="1988")
				{
					return true;
				}
				else
				{
					return false;

				}

			
			}
	}
}
