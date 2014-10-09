using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreationandDevelopment.Moods
{
    public partial class MoodUI2 : Form
    {
        private PlayerCharacter player;

        public MoodUI2(PlayerCharacter player)
        {
            InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
            this.player = player;
            UpdateScreen();
        }

        private void UpdateScreen()
        {
			player.GetMood();
			pictureBox1.Location = new Point(pictureBox1.Location.X, 150 - (int)Math.Round(player.happyDepressed * 1.5));
			pictureBox2.Location = new Point(pictureBox2.Location.X, 150 - (int)Math.Round(player.angryAfraid * 1.5));
			pictureBox3.Location = new Point(pictureBox3.Location.X, 150 - (int)Math.Round(player.excitedBored * 1.5));
			pictureBox4.Location = new Point(pictureBox4.Location.X, 150 - (int)Math.Round(player.logicalCrazy * 1.5));

			pictureBox1.Image = player.CurrentMood.GetMoodImage();
			pictureBox2.Image = player.CurrentMood.GetMoodImage();
			pictureBox3.Image = player.CurrentMood.GetMoodImage();
			pictureBox4.Image = player.CurrentMood.GetMoodImage();
			lblCurrentMood.Text = "Current Mood: " + player.CurrentMood.GetName();
        }
    }
}
