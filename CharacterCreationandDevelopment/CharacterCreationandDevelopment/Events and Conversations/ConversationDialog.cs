using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreationandDevelopment.Events_and_Conversations
{
	public partial class ConversationDialog : Form
	{
		private IConversation currentConversation;
		private PlayerCharacter player;
		private int speechNumber;
		private bool isSpeakerCharacter;

		public ConversationDialog(IConversation currentConversation, PlayerCharacter player)
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
			this.currentConversation = currentConversation;
			this.player = player;
			speechNumber = 0;
			isSpeakerCharacter = true;
			MoveConversationOn();
		}

		private void PopulateImages()
		{
			if (isSpeakerCharacter)
			{
				pBoxCharacter.Image = HelperClass.Images(player.gender)[player.portraitNumber];
				pBoxNPC.Image = null;
			}
			else
			{
				pBoxNPC.Image = currentConversation.conversationNPC.portrait;
				pBoxCharacter.Image = null;
			}
		}

		private void MoveConversationOn()
		{
			if (speechNumber < currentConversation.GetEventConversation().Count())
			{
				PopulateImages();
				txtConversation.Text += currentConversation.GetEventConversation()[speechNumber];
				speechNumber++;
			}
			else
			{
				btnNext.Enabled = false;
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			MoveConversationOn();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
