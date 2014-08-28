using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Events_and_Conversations
{
    public class GameStart : IEvent
    {
        PlayerCharacter player;
        NPC Dad;
        public GameStart(PlayerCharacter player)
        {
            this.player = player;
            Dad = new NPC();
        }

    }
}
