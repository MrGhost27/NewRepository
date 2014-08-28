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
            this.StartPosition = FormStartPosition.CenterScreen;
            GetSaves();
        }

        private void GetSaves()
        {
            string[] filePaths = Directory.GetFiles(@".\Saves\", "*.xml");

            foreach (string filePath in filePaths)
            {
                string newFiles = Path.GetFileNameWithoutExtension(filePath);

                comboBox1.Items.Add(newFiles);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerCharacter player = HelperClass.LoadPlayerDetailsFromFile(comboBox1.Text);
            WorldUI world = new WorldUI(player);
            world.Show();
            this.Close();
        }
    }
}
