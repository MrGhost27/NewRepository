using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreationandDevelopment
{
    public partial class SelectGame : Form
    {
        public SelectGame()
        {
            InitializeComponent();
            GetSaves();
        }

        private void GetSaves()
        {
            string[] filePaths = Directory.GetFiles(@".\Saves\", "*.xml");

            for (int i =0; i < filePaths.Count(); i++)
            {
                comboBox1.Items.Add(filePaths[i].ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerCharacter player = HelperClass.LoadPlayerDetailsFromFile(comboBox1.Text);
            WorldUI world = new WorldUI(player);
            world.Show();
        }
    }
}
