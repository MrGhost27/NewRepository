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
		public Context con = new Context();

		public Form1()
		{
			InitializeComponent();
			con.state = new locked();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			string output = con.performOpen();
			label1.Text = output;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string output = con.performUnlock();
			label1.Text = output;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string output = con.performLock();
			label1.Text = output;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string output = con.performClose();
			label1.Text = output;
		}
		
	}
}
