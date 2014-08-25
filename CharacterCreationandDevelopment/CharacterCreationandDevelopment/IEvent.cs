using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    interface IEvent
    {
        string EventText { get; set; }
        PlayerCharacter Character { get; set; }
        NPC NPC { get; set; }

    }
}
