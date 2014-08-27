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
        Character_Creation CharacterSheet;

        public WorldUI()
        {
            InitializeComponent();
            //this.player = playerinWorld;
            //this.CharacterSheet = CharSheet;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = player.Name;
            //this.CharacterSheet.Show();
            HelperClass.LoadPlayerDetailsFromFile(player.Name);
        }
    }
}
