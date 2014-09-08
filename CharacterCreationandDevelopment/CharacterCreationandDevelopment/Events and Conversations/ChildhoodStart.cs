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
        public NPC eventNPC { get; set; }
        private string choiceText;

        public ChildhoodStart(PlayerCharacter player)
        {
            this.player = player;
            eventNPC = new NPC("Bullies!");
            eventChoices = new List<String>();
            eventChoices.Add("Fight the bullies");
            eventChoices.Add("Talk them around");
            eventChoices.Add("Run Away");

            choiceText = "";
        }

        public NPC GetSibling()
        {
            return eventNPC;
        }

        public string ChoiceOne()
        {
            player.SetAngryAfraid(10);
            choiceText += "You are getting angry" + Environment.NewLine;
            choiceText += "Your unarmed skill is put to the test... " + Environment.NewLine;
            
            if (player.unarmed > 9)
            {
                choiceText += "You beat the bullies" + Environment.NewLine;
                player.SetHappyDepressed(30);
                choiceText += "You are Happy" + Environment.NewLine;
            }
            else
            {
                choiceText += "You fail to beat the bullies who beat you instead" + Environment.NewLine;
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
                choiceText += "You talk the bullies into leaving" + Environment.NewLine;
            }
            else
            {
                choiceText += "You cannot convince the bullies to leave and take a beating for your efforts" + Environment.NewLine;
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
                choiceText += "You manage to outrun the bullies, this time" + Environment.NewLine;
            }
            else
            {
                choiceText += "You cannot outrun the bullies, they catch and beat you" + Environment.NewLine;
                player.SetAngryAfraid(-50);
                choiceText += "You are afraid" + Environment.NewLine;
                player.SetHappyDepressed(-30);
                choiceText += "You are Depressed" + Environment.NewLine;
            }
            return choiceText;
        }

        public string EventConversation()
        {
            string conversation = "";
            conversation += player.name + ": Oh No! " + eventNPC.name + Environment.NewLine;
            conversation += eventNPC.name + ": Time for a Beating! " + player.name + Environment.NewLine;

            return conversation;
        }

        public string EventDecisionText()
        {
            string eventDecisionText = "";
            eventDecisionText += "Suddenly you are confronted by Bullies! \n How will you deal with them?";
            return eventDecisionText;
        }     
    }
}
