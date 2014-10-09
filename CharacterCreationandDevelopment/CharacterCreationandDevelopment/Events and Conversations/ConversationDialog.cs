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
			pBoxCharacter.Image = HelperClass.Images(player.gender)[player.portraitNumber];
			txtConversation.Text = currentConversation.GetEventConversation()[speechNumber];
			btnPrevious.Enabled = false;
		}

		private void NextSpeaker()
		{
			if (isSpeakerCharacter)
			{
				pBoxCharacter.Image = HelperClass.Images(player.gender)[player.portraitNumber];
				pBoxNPC.Image = null;
			}
			else
			{
				pBoxNPC.Image = currentConversation.conversationNPC.GetPortrait();
				pBoxCharacter.Image = null;
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (speechNumber == currentConversation.GetEventConversation().Count()-1)
			{
				btnNext.Enabled = false;
			}
			else
			{
				btnPrevious.Enabled = true;
				speechNumber++;
				txtConversation.Text = currentConversation.GetEventConversation()[speechNumber];
				isSpeakerCharacter = !isSpeakerCharacter;
				NextSpeaker();
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			if (speechNumber == 0)
			{
				btnPrevious.Enabled = false;
			}
			else
			{
				btnNext.Enabled = true;
				speechNumber--;
				txtConversation.Text = currentConversation.GetEventConversation()[speechNumber];
				isSpeakerCharacter = !isSpeakerCharacter;
				NextSpeaker();
			}
		}
	}
}
