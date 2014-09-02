using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreationandDevelopment
{
	public partial class JournalUI : Form
	{
		private int currentpage;
		private World world;
		public JournalUI(World world)
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
			this.world = world;
			this.currentpage = 1;

			DisplayPage(currentpage);
		}

		public void DisplayPage(int leftpage)
		{
			lblLeft.Text = world.GetJournalPage(leftpage, 500);
			lblRight.Text = world.GetJournalPage(leftpage +1, 500);
		}

		private void btnNextPage_Click(object sender, EventArgs e)
		{
			currentpage = currentpage+2;
			DisplayPage(currentpage);
			btnPreviousPage.Enabled = true;
		}

		private void btnPreviousPage_Click(object sender, EventArgs e)
		{
			currentpage = currentpage - 2;
			DisplayPage(currentpage);

			if (currentpage == 1)
			{
				btnPreviousPage.Enabled = false;
			}
		}
	}
}
