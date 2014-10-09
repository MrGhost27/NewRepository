using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statesv1
{
	public partial class Form1 : Form
	{
		public Door door = new Door();

		public Form1()
		{
			InitializeComponent();
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			string output = door.action(1);
			label1.Text = output;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string output = door.action(2);
			label1.Text = output;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string output = door.action(3);
			label1.Text = output;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string output = door.action(4);
			label1.Text = output;
		}

		private void label1_Click(object sender, EventArgs e)
		{
			string output = door.action(5);
			label1.Text = output;
		}
		
	}
}
