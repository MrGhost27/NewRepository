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
	public partial class EventOutcome : Form
	{
		private List<string> eventOutcomeList;
		private int speechNumber = 0;


		public EventOutcome(List<string> eventOutcomeList)
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
			this.eventOutcomeList = eventOutcomeList;
            txtConversation.Text = eventOutcomeList[speechNumber];
            btnPrevious.Enabled = false;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (speechNumber == eventOutcomeList.Count() - 1)
			{
				btnNext.Enabled = false;
			}
			else
			{
				btnPrevious.Enabled = true;
				speechNumber++;
				txtConversation.Text = eventOutcomeList[speechNumber];
			}
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
				txtConversation.Text = eventOutcomeList[speechNumber];
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
