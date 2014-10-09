using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    class WolfConversation : IConversation
	{
		public Relationship conversationNPC { get; set; }
		private PlayerCharacter player;
		private List<string> conversationParts;

        public WolfConversation(PlayerCharacter player)
		{
			this.player = player;
			conversationNPC = HelperClass.GetRelationshipFromList("Sister");
		}

		public List<string> GetEventConversation()
		{
			conversationParts = new List<string>();
			conversationParts.Add(player.name + ": " + conversationNPC.name + "! Are you ok? What's up?" );

			conversationParts.Add(conversationNPC.name + ": Oh " + player.name + "!" + Environment.NewLine  
                + "I'm soo bored! Can we go do something fun? How about going into the forest to climb trees! That's fun! " + Environment.NewLine
                + "Please please please!");

            return conversationParts;
		}
	}
}
