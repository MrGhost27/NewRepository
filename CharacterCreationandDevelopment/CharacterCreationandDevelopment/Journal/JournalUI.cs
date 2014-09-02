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
		public JournalUI(World world)
		{
			InitializeComponent();
			lblLeftPage.Text = world.GetJournalPage(1, 1000);
			lblRightPage.Text = world.GetJournalPage(2, 1000);
		}
	}
}
