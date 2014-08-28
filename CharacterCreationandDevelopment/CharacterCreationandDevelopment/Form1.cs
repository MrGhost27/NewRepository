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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Character_Creation CharCreation = new Character_Creation();
            CharCreation.Show();
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
            SelectGame loadgame = new SelectGame();
            loadgame.Show();
            this.Hide();
            //PlayerCharacter player = HelperClass.LoadPlayerDetailsFromFile(player.name);
           // WorldUI world = new WorldUI(player);
        }
    }
}
