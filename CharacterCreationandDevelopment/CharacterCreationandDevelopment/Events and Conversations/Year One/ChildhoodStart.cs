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
		public Relationship conversationNPC { get; set; }
		private List<string> conversationParts;
        private List<string> choiceText;

        public ChildhoodStart(PlayerCharacter player)
        {
            this.player = player;
			conversationNPC = new Bandit(1);
            eventChoices = new List<String>();
            eventChoices.Add("Fight the Bandits");
            eventChoices.Add("Talk them around");
            eventChoices.Add("Run Away");

            choiceText = new List<string>();
        }

		public List<string> ChoiceOne()
        {
            player.SetAngryAfraid(10);
			choiceText.Add("You are getting angry");
            choiceText.Add("Your unarmed skill is put to the test... ");
            
            if (player.unarmed > 9)
            {
                choiceText.Add("You beat the bandits");
                player.SetHappyDepressed(30);
            }
            else
            {
				choiceText.Add("You fail to beat the bandits who beat you instead");
                player.SetAngryAfraid(-50);
                player.SetHappyDepressed(-30);
            }
            return choiceText;
        }

        public List<string> ChoiceTwo()
        {
            choiceText.Add("Your Diplomacy skill is put to the test... (Requires 10 points)");

            if (player.diplomacy > 9)
            {
				choiceText.Add("You talk the bandits into leaving");
            }
            else
            {
				choiceText.Add("You cannot convince the bandits to leave and take a beating for your efforts");
                player.SetAngryAfraid(-50);
                player.SetHappyDepressed(-30);
            }
            return choiceText;
        }

        public List<string> ChoiceThree()
        {
            choiceText.Add("Your running skill is put to the test...");

            if (player.running> 9)
            {
				choiceText.Add("You manage to outrun the bandits, this time");
            }
            else
            {
				choiceText.Add("You cannot outrun the bandits, they catch and beat you");
                player.SetAngryAfraid(-50);
                player.SetHappyDepressed(-30);
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
