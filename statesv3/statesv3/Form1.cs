using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using statesv3.states;

namespace statesv3
{
	public partial class Form1 : Form
	{
		feet feet = new feet();
		int distance = 0;

		public Form1()
		{
			InitializeComponent();
			feet.state = new barefoot();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			label1.Text = feet.changeFootwear(1);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			label1.Text = feet.changeFootwear(2);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			label1.Text = feet.changeFootwear(3);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			label1.Text = feet.changeFootwear(4);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			label1.Text = feet.changeFootwear(5);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			label1.Text = feet.changeFootwear(6);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int temp = feet.state.run();

			if (temp != 0 && temp != 11)
			{
				distance = distance + temp;
				label2.Text = distance.ToString();
				label1.Text = "You ran " + temp.ToString() + " units";
			}
			else if (temp == 11)
			{
				distance = distance + temp;
				label2.Text = distance.ToString();
				label1.Text = "You ran " + temp.ToString() + " units. Seems even though his shoes are amazingly comfortable and built for running, they dont magically turn you into a blue hedgehog.";
			}
			else if (temp == 0)
			{
				if (feet.state.name == "barefoot")
				{
					label1.Text = "Its such a bad idea to run barefoot you decide it would be better to put some shoes on";
				}
				else if(feet.state.name == "socks")
				{
					label1.Text = "You try to run in your socks, but slip and fall on the slippery floor";
				}
			}
		}
	}
}
