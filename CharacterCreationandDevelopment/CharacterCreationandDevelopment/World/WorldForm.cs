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
    public partial class WorldForm : Form
    {
        World newWorld;
        public WorldForm()
        {
            InitializeComponent();
            newWorld = new World(playerInWorld);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newWorld.EndTurn();
        }
    }
}
