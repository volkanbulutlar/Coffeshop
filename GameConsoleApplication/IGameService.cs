using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleApplication
{
	interface IGameService
	{
		void Add(List<Game> games);
		void Update(List<Game> games);
		void Delete(List<Game> games);

	}
}
