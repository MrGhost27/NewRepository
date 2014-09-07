using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Events_and_Conversations
{
    public class GameStart : IEvent
    {
        private PlayerCharacter player;
        public List<String> eventChoices { get; set; }
        public NPC eventNPC { get; set; }

        public GameStart(PlayerCharacter player)
        {
            this.player = player;
            eventNPC = new NPC();
            eventChoices = new List<String>();
            eventChoices.Add("Live");
            eventChoices.Add("Die");
        }

        public string ChoiceOne()
        {
            player.boredAngry = -100;
            player.happyDepressed = 0;

            return "You chose Live";
        }

        public string ChoiceTwo()
        {
            player.saneInsane = -100;
            player.happyDepressed = 0;
            return "You chose Die";
        }

        public string ChoiceThree()
        {
            return "";
        }

        public string EventConversation()
        {
            string conversation = "";
            conversation += player.name + ": Hi " + eventNPC.name + Environment.NewLine;
            conversation += eventNPC.name + ": Hi " + player.name + Environment.NewLine;
            conversation += eventNPC.name + ": Would you like to die? " + Environment.NewLine;

            return conversation;
        }

        public string EventDecisionText()
        {
            string eventDecisionText = "";
            eventDecisionText += "Suddenly you are forced to make a choice! \n Do you want to Die?";
            eventDecisionText += "\n Do you want to Live? \n Who knows! ...well hopefully you...\n So what's it going to be?";
            return eventDecisionText;
        }     
    }
}
