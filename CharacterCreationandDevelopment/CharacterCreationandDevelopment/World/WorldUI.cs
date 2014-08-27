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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = player.Name;
            //this.CharacterSheet.Show();
            this.player = HelperClass.LoadPlayerDetailsFromFile(player.name);
            textBox1.Text = player.name;
            Character_Creation CharacterSheet = new Character_Creation(player, 2);
            CharacterSheet.Show();


        }
    }
}
