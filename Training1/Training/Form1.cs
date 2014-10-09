using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training
{
	public partial class Form1 : Form
	{
		private World world;
		public Form1()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void label1_Click(object sender, EventArgs e)
		{
			world = new World();
			WorldUI worldUI = new WorldUI(world, this);
			worldUI.Show();
			this.Hide();
		}

		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		}

		private void label1_MouseLeave(object sender, EventArgs e)
		{
			label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		}

		private void label3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void label3_MouseLeave(object sender, EventArgs e)
		{
			label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
		}

		private void label3_MouseMove(object sender, MouseEventArgs e)
		{
			label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		}

		private void label2_MouseLeave(object sender, EventArgs e)
		{
			label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		}

		private void label2_MouseMove(object sender, MouseEventArgs e)
		{
			label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		}

		private void label2_Click(object sender, EventArgs e)
		{
			/*
			world = SaveLoad.SaveLoad.LoadWorld("DirectoryHere");
			WorldUI worldUI = new WorldUI(world);
			worldUI.Show();
			this.Hide();
			 * */
		}
	}
}
