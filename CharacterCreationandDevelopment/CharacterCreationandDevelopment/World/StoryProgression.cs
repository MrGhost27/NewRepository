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
		public int wolfEvent { get; set; }

        public StoryProgression(bool firstConversation, int wolfEvent)
        {
            this.firstConversation = firstConversation;
			this.wolfEvent = wolfEvent;
        }
    }
}
