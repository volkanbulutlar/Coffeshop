using System;
using System.Collections.Generic;

namespace GameConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			IMusteriManager musteriManager = new MusteriManager(new UserValidationManager());

			musteriManager.Ekle(new Musteri {Id=1, Ad = "Volkan", Soyad = "Bulutlar", TcNo = "1231231", DogumYılı = "1988" ,Musteri_No = "123131" , DogumTarih = "12313131" });
			musteriManager.Sil(new Musteri { Id = 1, Ad = "Volkan", Soyad = "Bulutlar", TcNo = "1231231", DogumYılı = "1988", Musteri_No = "123131", DogumTarih = "12313131" });
			musteriManager.Guncelle(new Musteri { Id = 1, Ad = "Volkan", Soyad = "Bulutlar", TcNo = "1231231", DogumYılı = "123", Musteri_No = "123131", DogumTarih = "12313131" });

			IGameService gameService = new GameManager();
			Game game1 = new Game();
			game1.Id = 1;
			game1.GameName = "The Last Of Us ";
			game1.GamePrice = 12.50;

			Game game2 = new Game();
			game2.Id = 2;
			game2.GameName = "Fifa 21";
			game2.GamePrice = 15;

			Game game3 = new Game();
			game3.Id = 3;
			game3.GameName = "Uncharted 4 ";
			game3.GamePrice = 13.30;

			gameService.Add(new List<Game> {game1,game2,game3} );


			ICampaignService campaignManager = new CampaignManager();
			Campaign campaign = new Campaign();

			campaign.Id = 1;
			campaign.CampaignName = "Nisan Ayı İndirimleri";
			campaign.CapmpaignDiscount = 30;


			campaignManager.Add(game1,campaign);







		}
	}
}
