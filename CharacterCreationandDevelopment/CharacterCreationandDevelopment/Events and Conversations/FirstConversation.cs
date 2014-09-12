using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
	public class FirstConversation : IConversation
	{
		public Relationship conversationNPC { get; set; }
		private PlayerCharacter player;
		private List<string> conversationParts;

		public FirstConversation(PlayerCharacter player)
		{
			this.player = player;
			conversationNPC = HelperClass.GetRelationshipFromList("Sister");
            conversationNPC.opinionofPlayer = 0;
			HelperClass.listOfRelationships.Add(new Sister());
		}

		public List<string> GetEventConversation()
		{
			conversationParts = new List<string>();
			conversationParts.Add(player.name + ": Hi " + conversationNPC.name + Environment.NewLine);

			conversationParts.Add(conversationNPC.name + ": Hi " + player.name + "!" + Environment.NewLine
                + "Mum sent me to tell you to do some chores around the farm instead of just relaxing all the time." + Environment.NewLine
                + "If you want though, we could sneak off and go play instead!" + Environment.NewLine);

			conversationParts.Add(player.name + ": I'll think on it - you always were a bad influence on me" + Environment.NewLine);

			conversationParts.Add(conversationNPC.name + ": Hey - that's what sisters are for!" + Environment.NewLine);

            return conversationParts;
		}
	}
}
