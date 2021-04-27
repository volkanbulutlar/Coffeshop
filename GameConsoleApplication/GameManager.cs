using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleApplication
{
	class GameManager : IGameService
	{
		public void Add(List<Game> games )
		{
			foreach (var game in games)
			{
				Console.WriteLine(game.GameName + " Oyunu Fiyatı " + game.GamePrice + " TL Olarak Eklendi");
			}
		}

		public void Delete(List<Game> games )
		{
			foreach (var game in games)
			{
				Console.WriteLine(game.GameName + " Oyunu Fiyatı " + game.GamePrice + " TL Olarak Güncellendi");
			}
		}

		public void Update(List<Game> games)
		{
			foreach (var game in games)
			{
				Console.WriteLine(game.GameName + " Oyunu Fiyatı " + game.GamePrice + " TL Olarak Eklendi");
			}
		}
	}
}
