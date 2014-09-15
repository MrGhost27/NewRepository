using CharacterCreationandDevelopment.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class World
    {
        public int monthNumber { get; private set; }
        public int year { get; private set; }
        string journalEntries { get; set; }
        public IEvent newEvent;
		public IConversation newConversation;
        PlayerCharacter player;
		Journal journal;

        public World(PlayerCharacter player, int monthNumber, int year, string journalEntries)
        {
            this.player = player;
            this.monthNumber = monthNumber;
            this.year = year;
			journal = new Journal(this, player);
            journal.SetJournal(journalEntries);
        }

		public string AddJournalEntry(string entry)
		{
			return journal.NewEntry(entry);
		}

		public string GetJournalPage(int pageNumber, int numberOfCharacters)
		{
			return journal.GetPage(pageNumber, numberOfCharacters);
		}

		public string GetJournal()
		{
			return journal.GetJournal();
		}

		public void SetConversation(IConversation thisConversation)
		{
			this.newConversation = thisConversation;
		}


        public void SetEvent(IEvent thisevent)
        {
            this.newEvent = thisevent;
        }

		public void LogEventConversation(List<string> eventConversation)
		{
            string journalEntry = "";
			foreach (string speech in eventConversation)
			{
                journalEntry += speech;
				journalEntry += Environment.NewLine;
			}
            AddJournalEntry(journalEntry);
		}

		public List<string> EventDecision(int eventDecisionChoice)
		{
			if (eventDecisionChoice == 1)
			{
				return newEvent.ChoiceOne();
			}
			if (eventDecisionChoice == 2)
			{
				return newEvent.ChoiceTwo();
			}
			if (eventDecisionChoice == 3)
			{
				return newEvent.ChoiceThree();
			}
			return null;
		}

        public string NewTurn()
        {
            monthNumber++;

            if (monthNumber == 13)
            {
                monthNumber = 1;
                year++;
            }

            return GetDate();
        }

        public string GetDate()
        {
            return GetMonth() + " " + year;
        }

        public string GetMonth()
        {
            switch(monthNumber)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
            }
            return "";
        }
    }
}
