using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Events_and_Conversations
{
    public class ChildhoodStart : IEvent
    {
        private PlayerCharacter player;
        public List<String> eventChoices { get; set; }
		public ICharacter conversationNPC { get; set; }
		private List<string> conversationParts;
        private string choiceText;

        public ChildhoodStart(PlayerCharacter player)
        {
            this.player = player;
			conversationNPC = new Bandit(1);
            eventChoices = new List<String>();
            eventChoices.Add("Fight the Bandits");
            eventChoices.Add("Talk them around");
            eventChoices.Add("Run Away");

            choiceText = "";
        }

		public string ChoiceOne()
        {
            player.SetAngryAfraid(10);
            choiceText += "You are getting angry" + Environment.NewLine;
            choiceText += "Your unarmed skill is put to the test... " + Environment.NewLine;
            
            if (player.unarmed > 9)
            {
                choiceText += "You beat the bandits" + Environment.NewLine;
                player.SetHappyDepressed(30);
                choiceText += "You are Happy" + Environment.NewLine;
            }
            else
            {
				choiceText += "You fail to beat the bandits who beat you instead" + Environment.NewLine;
                player.SetAngryAfraid(-50);
                choiceText += "You are afraid" + Environment.NewLine;
                player.SetHappyDepressed(-30);
                choiceText += "You are Depressed" + Environment.NewLine;
            }

            return choiceText;
        }

        public string ChoiceTwo()
        {
            choiceText += "Your Diplomacy skill is put to the test... (Requires 10 points)" + Environment.NewLine;

            if (player.diplomacy > 9)
            {
				choiceText += "You talk the bandits into leaving" + Environment.NewLine;
            }
            else
            {
				choiceText += "You cannot convince the bandits to leave and take a beating for your efforts" + Environment.NewLine;
                player.SetAngryAfraid(-50);
                choiceText += "You are afraid" + Environment.NewLine;
                player.SetHappyDepressed(-30);
                choiceText += "You are Depressed" + Environment.NewLine;
            }

            return choiceText;
        }

        public string ChoiceThree()
        {
            choiceText += "Your Athletics skill is put to the test... (Requires 10 points)" + Environment.NewLine;

            if (player.athletics > 9)
            {
				choiceText += "You manage to outrun the bandits, this time" + Environment.NewLine;
            }
            else
            {
				choiceText += "You cannot outrun the bandits, they catch and beat you" + Environment.NewLine;
                player.SetAngryAfraid(-50);
                choiceText += "You are afraid" + Environment.NewLine;
                player.SetHappyDepressed(-30);
                choiceText += "You are Depressed" + Environment.NewLine;
            }
            return choiceText;
        }

        public List<string> GetEventConversation()
        {
			conversationParts = new List<string>();
			conversationParts.Add(player.name + ": Hi" + conversationNPC.name + Environment.NewLine);
			conversationParts.Add(conversationNPC.name + ": Give me all your money!" + Environment.NewLine);
			conversationParts.Add(player.name + ": I don't have any!" + Environment.NewLine);
			conversationParts.Add(conversationNPC.name + ": Time for a beating" + Environment.NewLine);
            return conversationParts;
        }

        public string EventDecisionText()
        {
            string eventDecisionText = "";
			eventDecisionText += "Suddenly you are confronted by bandits! \n How will you deal with them?";
            return eventDecisionText;
        }     
    }
}
