using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
	class BasvuruManager
	{
		//Method İnjection 
		public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
		{
			krediManager.Hesapla();
			foreach (var logger in loggerServices)
			{
				logger.Log();
			}

		}
	
		public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler,List<ILoggerService> loggerServices)
		{

			foreach (var kredi in krediler)
			{
				kredi.Hesapla();
				foreach (var logger in loggerServices)
				{
					logger.Log();

				}

			}


		}

	
	}
}
