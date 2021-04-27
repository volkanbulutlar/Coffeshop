using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleApplication
{
	class CampaignManager : ICampaignService
	{
		public void Add(Game game, Campaign campaign)
		{
			Console.WriteLine(game.GameName + " oyunu için " + campaign.CapmpaignDiscount + " TL kampanyalı fiyat eklenmiştir.");
		}

		public void Delete(Game game, Campaign campaign)
		{
			Console.WriteLine(game.GameName + " oyunu için " + campaign.CampaignName + "  kampanyası kaldırılmıştır");
		}

		public void Update(Game game, Campaign campaign)
		{
			Console.WriteLine(game.GameName + " oyunu için " + campaign.CampaignName + " kampanyası " + campaign.CapmpaignDiscount + " TL  indirimli fiyat olarak güncellenmiştir.");

		}
	}
}
