﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public interface IEvent
    {
        NPC eventNPC { get; set; }
        string EventConversation();
        string MakeChoice(string choice);
    }
}
