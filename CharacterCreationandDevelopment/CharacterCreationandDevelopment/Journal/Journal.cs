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
			int startIndex = numberOfCharacters * (pageNumber-1);
			string pageText = "";

			if (numberOfCharacters > (journal.Length - startIndex))
			{
				numberOfCharacters = (journal.Length - startIndex);
			}

			if (startIndex < journal.Length)
			{
				pageText = journal.Substring(startIndex, numberOfCharacters);
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
