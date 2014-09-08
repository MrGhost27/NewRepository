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
            this.player = player;
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            int relativezero = panel1.Size.Height / 2;
            int hundred = panel1.Location.Y;
            int difference = hundred - relativezero;
            int onepercent = (panel1.Size.Height / 100) * 100;

            pictureBox1.Location = new Point(pictureBox1.Location.X, (panel1.Size.Height/2) - (player.happyDepressed * 2));
            //pictureBox2.Location = new Point(pictureBox2.Location.X, player.boredAngry/10);
            //pictureBox3.Location = new Point(pictureBox3.Location.X, player.fearlessScared/10);
            //pictureBox4.Location = new Point(pictureBox4.Location.X, player.saneInsane/10);
        }
    }
}
