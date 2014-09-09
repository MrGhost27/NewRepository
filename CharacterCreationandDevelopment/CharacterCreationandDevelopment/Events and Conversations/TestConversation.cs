using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
	public class TestConversation : IConversation
	{
		public ICharacter conversationNPC { get; set; }
		private PlayerCharacter player;
		private List<string> conversationParts;

		public TestConversation(PlayerCharacter player)
		{
			this.player = player;
			conversationNPC = new Bandit(1);
		}

		public List<string> GetEventConversation()
		{
			conversationParts = new List<string>();
			conversationParts.Add(player.name + ": Hi " + conversationNPC.name + Environment.NewLine);
			conversationParts.Add(conversationNPC.name + ": Hi" + Environment.NewLine);
			conversationParts.Add(player.name + ": I'm Talking" + Environment.NewLine);
			conversationParts.Add(conversationNPC.name + ": Now I Am" + Environment.NewLine);
			return conversationParts;
		}
	}
}
