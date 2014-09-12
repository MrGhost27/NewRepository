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
        private Form parentForm;
		private List<string> Directories;
		private string selectedSave;

        public SelectGame(Form parentForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            GetSaves();
            this.parentForm = parentForm;
        }

        private void GetSaves()
        {
			Directories = new List<string>();
            try
            {
                string[] filePaths = Directory.GetDirectories(@".\Saves\");
                foreach (string filePath in filePaths)
                {
					Directories.Add(filePath + @"\Player");
                    comboBox1.Items.Add(Path.GetFileName(filePath));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No save games?!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
				string selectedGame = Directories[comboBox1.SelectedIndex] + @"\" + selectedSave;
				PlayerCharacter player = SaveLoad.LoadPlayerDetailsFromFile(selectedGame);
				StoryProgression storyProgression = SaveLoad.LoadStoryProgressionFromFile(player);
				World world = SaveLoad.LoadWorldDetailsFromFile(player);
				SaveLoad.LoadAllRelationships(player);

                WorldUI worldUI = new WorldUI(player, world, parentForm, storyProgression);
                worldUI.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to load the selected save game");
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] saveGames = Directory.GetFiles(Directories[comboBox1.SelectedIndex], "*.xml");
                listOfSaves.Items.Clear();

                foreach (string saveGame in saveGames)
                {
                    string thisSave = Path.GetFileNameWithoutExtension(saveGame);
					selectedSave = Path.GetFileName(saveGame);
                    listOfSaves.Items.Insert(0,thisSave);
                }
                listOfSaves.SetSelected(0, true);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable select save game");
            }
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
				selectedSave = listOfSaves.GetItemText(listOfSaves.SelectedItem)+".xml";
				string selectedGame = Directories[comboBox1.SelectedIndex] + @"\" + selectedSave;
				PlayerCharacter player = SaveLoad.LoadPlayerDetailsFromFile(selectedGame);
                pBoxChar.Image = HelperClass.Images(player.gender)[player.portraitNumber];
                UpdateMiniSkillsBox(player);
            }
        }
    }
}
