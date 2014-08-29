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
        Form parentForm;
        public SelectGame(Form parentForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            GetSaves();
            this.parentForm = parentForm;
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
            try
            {
                PlayerCharacter player = HelperClass.LoadPlayerDetailsFromFile(comboBox1.Text);
                WorldUI world = new WorldUI(player);
                world.Show();
                this.Close();
                parentForm.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to load the selected save game");
            }
        }
    }
}
