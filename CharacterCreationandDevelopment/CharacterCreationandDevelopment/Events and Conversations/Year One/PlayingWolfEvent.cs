using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Events_and_Conversations
{
	public class PlayingWolfEvent : IEvent
	{
		private PlayerCharacter player;
		public List<string> eventChoices { get; set; }
		public Relationship conversationNPC { get; set; }
		private List<string> conversationParts;
		private List<string> choiceText;

		public PlayingWolfEvent(PlayerCharacter player)
		{
			this.player = player;
			conversationNPC = HelperClass.GetRelationshipFromList("Sister");
			eventChoices = new List<string>();
			eventChoices.Add("Climb a Tree");
			eventChoices.Add("Try to tame the wolf");
			eventChoices.Add("Try to attack the wolf");

			choiceText = new List<string>();
		}

		public List<string> ChoiceOne()
        {
			player.SetAngryAfraid(-20);
            //choiceText += "Your fear levels are rising" + Environment.NewLine;
			choiceText.Add("Your climbing skill is put to the test... ");

            if (player.climbing > 20)
            {
				choiceText.Add("You manage to climb the tree, but you leave " + conversationNPC.name + " on the ground!");
				choiceText.Add("She tries to climb a tree, but slips and falls! She Screams!");
				choiceText.Add("You watch on horrified as the wolves attack her. Eventually a grown up comes and scares the wolves away.");
				conversationNPC.ChangeOpinion(-30);
                player.SetHappyDepressed(-20);
            }
            else if (conversationNPC.opinionofPlayer > 50)
            {
				choiceText.Add("You try to climb the tree, but you just can't seem to find your footing!");
				choiceText.Add(conversationNPC.name + " lifts you up so you can reach a branch, leaving her on the ground!");
				choiceText.Add("After she knows you're safe, she tries to climb a tree, but slips and falls! She Screams!");
				choiceText.Add("You watch on horrified as the wolves attack her. Eventually a grown up comes and scares the wolves away.");
				conversationNPC.ChangeOpinion(-30);
                player.SetHappyDepressed(-20);
            }
			else 
			{
				choiceText.Add("You try to climb the tree, but you just can't seem to find your footing! You fall!");
				choiceText.Add(conversationNPC.name + " is just too scared to help you. She tries to run away. She manages to escape while your failure distracts the wolves!");
				choiceText.Add("You are bitten and mauled multiple times. The sight of your own blood causes you to lose conciousness....");
				choiceText.Add("You wake up in your bed, having been rescued by grown ups.");
				choiceText.Add("Walking around is harder, you find you have a limp for a couple of months.");
				player.running = 0; 
				player.SetHappyDepressed(-50);
			}

            return choiceText;
        }

		public List<string> ChoiceTwo()
		{
			choiceText.Add("Your Animal Empathy skill is put to the test... ");

			if (player.animalEmpathy > 20)
			{
				choiceText.Add("You calmly approach the wolves, keeping " + conversationNPC.name + " behind you");
				choiceText.Add("You can sense the hunger from the wolves, but also anxiety. You look around for the cause of the anxiety and spot a wolf cub that had wandered into where you were playing");
				choiceText.Add("You back away slowly, keeping eye contact with the pack leader. You take " + conversationNPC.name + " and attempt leave the area");
				choiceText.Add("The wolves snarl at you as you go, but otherwise do not attack. You escape.");
			}
			else
			{
				choiceText.Add("You calmly approach the wolves, keeping " + conversationNPC.name + " behind you");
				choiceText.Add("You realise this was a crazy idea as soon as you get close enough to see the eyes of the wolves.");
				choiceText.Add("The wolves look rabid to you, you turn your back to run when they attack!");
				player.SetLogicalCrazy(-100);
				choiceText.Add(conversationNPC.name + " is just too scared to help you. She tries to run away. She manages to escape while your failure distracts the wolves!");
				choiceText.Add("You are bitten and mauled multiple times. The sight of your own blood causes you to lose conciousness....");
				choiceText.Add("Walking around is harder, you find you have a limp for a couple of months.");
				player.running = 0;
				player.SetHappyDepressed(-50);
			}

			return choiceText;
		}

		public List<string> ChoiceThree()
		{
			choiceText.Add("Your unarmed skill is put to the test...");

			if (player.unarmed > 20)
			{
				choiceText.Add("You have no weapons but you realise you have to defend " + conversationNPC.name+"!");
				choiceText.Add("You try throwing rocks to get the attention of the wolves away from her. She looks scared to death!");
				choiceText.Add("One of the rocks lands right on the face of the lead wolf, he let's out a growl, the pack focuses it's attention on you!");
				choiceText.Add("You are a hero to your sister, who runs away to get help!");
				conversationNPC.ChangeOpinion(100);
				choiceText.Add("You put up a great fight and manage to convince the wolves you're a threat to be reckoned with. The wolves leave.");
				player.animalEmpathy -= 20;
				if (player.animalEmpathy < 0)
					player.animalEmpathy = 0;
			}
			else
			{
				choiceText.Add("You have no weapons but you realise you have to defend " + conversationNPC.name + "!");
				choiceText.Add("You try throwing rocks to get the attention of the wolves away from her. She looks scared to death!");
				choiceText.Add("One of the rocks lands right on the ground near the lead wolf, he let's out a growl, the pack focuses it's attention on you!");
				choiceText.Add("You are a hero to your sister, who runs away to get help!");
				conversationNPC.ChangeOpinion(100);
				choiceText.Add("You are bitten and mauled multiple times. The sight of your own blood causes you to lose conciousness....");
				choiceText.Add("Walking around is harder, you find you have a limp for a couple of months.");
				player.running = 0;
			}
			return choiceText;
		}

		public List<string> GetEventConversation()
		{
			conversationParts = new List<string>();
			conversationParts.Add(player.name + ": This was a great idea, " + conversationNPC.name + ". Thanks for suggesting it! I've had lots of fun!");
			conversationParts.Add(conversationNPC.name + ": It has been great hasn't it! I'm glad we spend this time together. We should head back now, it's nearly supper and my arms are tired" + Environment.NewLine
				+ "...What was that sound!?!");
			conversationParts.Add(player.name + ": It sounded like growling...");
			conversationParts.Add(conversationNPC.name + ": Oh No! Wolves! What are we going to do? "
				+ "I don't think I can climb any more trees, my arms are too tired! Should we run away?");
			return conversationParts;
		}

		public string EventDecisionText()
		{
			string eventDecisionText = "";
			eventDecisionText += "Will you climb a tree and abandon your sister? \n " +
								 "Will you attempt to tame a wolf? \n " +
								 "Will you attack the wolves in an effort to draw all the attention from your sister?";
			return eventDecisionText;
		}
	}
	
}
