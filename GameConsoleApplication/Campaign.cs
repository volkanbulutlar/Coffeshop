using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleApplication
{
	class Campaign:CampaignManager
	{
		public int Id { get; set; }
		public string CampaignName { get; set; }
		public double CapmpaignDiscount { get; set; }
	}
}
