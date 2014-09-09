using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class StoryProgression
    {
        public bool firstConversation { get; set; }

        public StoryProgression(bool firstConversation)
        {
            this.firstConversation = firstConversation;
        }
    }
}
