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
            string[] filePaths = Directory.GetDirectories(@".\Saves\");

            foreach (string filePath in filePaths)
            {
                comboBox1.Items.Add(filePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedGame = comboBox1.Text + @"\" + listOfSaves.SelectedItem.ToString();
                PlayerCharacter player = HelperClass.LoadPlayerDetailsFromFile(selectedGame);
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

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string[] saveGames = Directory.GetFiles(comboBox1.Text, "*.xml");
            listOfSaves.Items.Clear();

            foreach (string saveGame in saveGames)
            {
                string thisSave = Path.GetFileNameWithoutExtension(saveGame);
                listOfSaves.Items.Add(thisSave);
            }
            listOfSaves.SetSelected(0, true);
        }

        private void UpdateMiniSkillsBox(PlayerCharacter player)
        {
            pBarAnimalEmpathy.Value = player.animalEmpathy;
            pBarAthletics.Value = player.athletics;
            pBarCrafting.Value = player.crafting;
            pBarDiplomacy.Value = player.diplomacy;
            pBarFaith.Value = player.faith;
            pBarLockpicking.Value = player.lockpicking;
            pBarMedicine.Value = player.medicine;
            pBarPickPocketing.Value = player.pickpocketing;
            pBarScience.Value = player.science;
            pBarSurvival.Value = player.survival;
            pBarSwimming.Value = player.swimming;
            pBarUnarmed.Value = player.unarmed;
            pBarWeapons.Value = player.weapons;          
        }

        private void listOfSaves_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listOfSaves.SelectedItem != null)
            {
                string selectedGame = comboBox1.Text + @"\" + listOfSaves.SelectedItem.ToString();
                PlayerCharacter player = HelperClass.LoadPlayerDetailsFromFile(selectedGame);
                pBoxChar.Image = HelperClass.Images()[player.portraitNumber];
                UpdateMiniSkillsBox(player);
            }
        }
    }
}
