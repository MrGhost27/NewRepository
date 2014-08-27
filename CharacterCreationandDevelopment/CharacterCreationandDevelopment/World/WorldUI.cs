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
    public partial class WorldUI : Form
    {
        PlayerCharacter player;

        public WorldUI(PlayerCharacter playerInWorld)
        {
            InitializeComponent();
            this.player = playerInWorld;
            pictureBox1.Image = HelperClass.Images()[player.portraitNumber];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = player.Name;
            //this.CharacterSheet.Show();
            this.player = HelperClass.LoadPlayerDetailsFromFile(player.name);
            Character_Creation CharacterSheet = new Character_Creation(player, 0);
            CharacterSheet.Show();


        }

        private void WorldUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 x = new Form1();
            x.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.player = HelperClass.LoadPlayerDetailsFromFile(player.name);
            Character_Creation CharacterSheet = new Character_Creation(player, 0);
            CharacterSheet.ShowDialog();
        }
    }
}
