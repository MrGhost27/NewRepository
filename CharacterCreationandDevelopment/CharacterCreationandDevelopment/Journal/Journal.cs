using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
	public class Journal
	{
		private World world;
		private PlayerCharacter player;
		private string journal;

		public Journal(World world, PlayerCharacter player)
		{
			this.world = world;
			this.player = player;
            journal = "";
		}

		public string NewEntry(string entry)
		{
			string newEntry = "";
			newEntry += Environment.NewLine;
			newEntry += world.GetMonth() + ", " + world.year + ": " + Environment.NewLine;
			newEntry += entry;
			journal += newEntry;
			return newEntry;
		}

		public string GetPage(int pageNumber, int numberOfCharacters)
		{
			int startindex = 0;
			int endIndex = startindex + numberOfCharacters;
			if (endIndex > journal.Length)
			{
				endIndex = journal.Length;
			}

			string pageText = "";
			for (int i = 0; i < pageNumber; i++)
			{
				pageText = journal.Substring(startindex, endIndex);
                startindex = pageText.Length;
			}
			return pageText;
		}
        public void SetJournal(string journal)
        {
            this.journal = journal;
        }

		public string GetJournal()
		{
			return journal;
		}
	}
}
