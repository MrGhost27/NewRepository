using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public interface IEvent
    {
        string RunEvent(PlayerCharacter player, NPC npc);
    }
}
