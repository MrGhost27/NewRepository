using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Events_and_Conversations
{
    public class GameStart : IEvent
    {
        public PlayerCharacter player;
        public NPC eventNPC { get; set; }

        public GameStart(PlayerCharacter player)
        {
            this.player = player;
            eventNPC = new NPC();
        }

        public string EventConversation()
        {
            string conversation = "";
            conversation += player.name + ": Hi " + eventNPC.name + Environment.NewLine;
            conversation += eventNPC.name + ": Hi " + player.name + Environment.NewLine;
            conversation += eventNPC.name + ": Would you like to die? " + Environment.NewLine;

            return conversation;
        }

        public string MakeChoice(string choice)
        {
            if (choice == "Yes")
            {
                return player.name + " said yes";
            }
            else
            {
                return player.name + " said no"; 
            }
        }
       
    }
}
