using System;
using System.Collections.Generic;

namespace OOP4
{
	class Program
	{
		static void Main(string[] args)
		{
			IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

			IKrediManager tasitKrediManager = new TasitKrediManager();

			IKrediManager konutKrediManager = new KonutKrediManager();
			IKrediManager esnafKrediManager = new EsnafKredisiManager();


			ILoggerService databaseloggerService = new DatabaseLoggerService();
			ILoggerService fileLoggerService = new FileLoggerService();
			ILoggerService smsLoggerService = new SmsLoggerService();





			BasvuruManager basvuruManager = new BasvuruManager();
			//basvuruManager.BasvuruYap(esnafKrediManager, fileLoggerService) ;


			List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};


			basvuruManager.KrediOnBilgilendirmesiYap(krediler,new List<ILoggerService>() { databaseloggerService, fileLoggerService, smsLoggerService });

		}
	}
}
