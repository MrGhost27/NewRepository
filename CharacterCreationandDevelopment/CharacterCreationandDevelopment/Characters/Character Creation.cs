using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CharacterCreationandDevelopment
{
    public partial class Character_Creation : Form
    {
        public int remainingPoints { get; private set; }
        public int _strength { get; private set; }
        public int _dexterity { get; private set; }
        public int _consitution { get; private set; }
        public int _intelligence { get; private set; }
        public int _wisdom { get; private set; }
        public int _charisma { get; private set; }
        public string _name { get; private set; }
        public int imageNumber { get; private set; }
		public int gender { get; private set; }
		public PlayerCharacter player { get; private set; }
        private Form parentForm;

        public Character_Creation(Form parentForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.parentForm = parentForm;
			cBoxGender.Text = "Male";
			gender = 1;
            SetAttributes();
            imageNumber = 0;
            pBoxImage.Image = HelperClass.Images(gender)[imageNumber];
            remainingPoints = 10;
            txtRemainingPoints.Text = remainingPoints.ToString();
       }

        public Character_Creation(PlayerCharacter player, int PointsToAllocate, Form parentForm)
        {
            InitializeComponent();
            SetAttributes();
            this.Text = "Character Sheet";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.parentForm = parentForm;
            btnCreateCharacter.Text = "Level Up";
            gender = player.gender;
            if (gender ==0)
            {
                cBoxGender.Text = "Female";
            }
            else
            {
                cBoxGender.Text = "Male";
            }
            txtName.Text = player.name;
            txtName.Enabled = false;
            btnPreviousPic.Visible = false;
            btnNext.Visible = false;
            btnReset.Visible = false;
            buttonRandomName.Visible = false;

            numericStr.Value = player.strength;
            numericDex.Value = player.dexterity;
            numericCon.Value = player.constitution;
            numericInt.Value = player.intelligence;
            numericWis.Value = player.wisdom;
            numericCha.Value = player.charisma;
            imageNumber = player.portraitNumber;
            pBoxImage.Image = HelperClass.Images(gender)[player.portraitNumber];

            if (PointsToAllocate == 0)
            {
                numericStr.Enabled = false;
                numericDex.Enabled = false;
                numericCon.Enabled = false;
                numericInt.Enabled = false;
                numericWis.Enabled = false;
                numericCha.Enabled = false;
                cBoxGender.Enabled = false;
                remainingPoints = 0;
                btnCreateCharacter.Visible = false;
            }
            else
            {
                numericStr.Enabled = true;
                numericDex.Enabled = true;
                numericCon.Enabled = true;
                numericInt.Enabled = true;
                numericWis.Enabled = true;
                numericCha.Enabled = true;
                remainingPoints = PointsToAllocate;
                btnCreateCharacter.Visible = true;
            }
            txtRemainingPoints.Text = remainingPoints.ToString();
        }

        private void SetAttributes()
        {
            _strength = (int)numericStr.Value;
            _dexterity = (int)numericDex.Value;
            _consitution = (int)numericCon.Value;
            _intelligence = (int)numericInt.Value;
            _wisdom = (int)numericWis.Value;
            _charisma = (int)numericCha.Value;
            _name = txtName.Text;
        }

        private void buttonRandomName_Click(object sender, EventArgs e)
        {
            RandomName(gender);
        }

		private void RandomName(int gender)
		{
			txtName.Text = HelperClass.RandomName(gender);
			_name = txtName.Text;
		}

        #region ValueChanged
        
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            _name = txtName.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericStr.Value < 5)
            {
                numericStr.Value = 5;
            }

            remainingPoints += _strength - (int)numericStr.Value;
            _strength = (int)numericStr.Value;
            txtRemainingPoints.Text = remainingPoints.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericDex.Value < 5)
            {
                numericDex.Value = 5;
            }

            remainingPoints += _dexterity - (int)numericDex.Value;
            _dexterity = (int)numericDex.Value;
            txtRemainingPoints.Text = remainingPoints.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericCon.Value < 5)
            {
                numericCon.Value = 5;
            }

            remainingPoints += _consitution - (int)numericCon.Value;
            _consitution = (int)numericCon.Value;
            txtRemainingPoints.Text = remainingPoints.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericInt.Value < 5)
            {
                numericInt.Value = 5;
            }

            remainingPoints += _intelligence - (int)numericInt.Value;
            _intelligence = (int)numericInt.Value;
            txtRemainingPoints.Text = remainingPoints.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (numericWis.Value < 5)
            {
                numericWis.Value = 5;
            }

            remainingPoints += _wisdom - (int)numericWis.Value;
            _wisdom = (int)numericWis.Value;
            txtRemainingPoints.Text = remainingPoints.ToString();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (numericCha.Value < 5)
            {
                numericCha.Value = 5;
            }

            remainingPoints += _charisma - (int)numericCha.Value;
            _charisma = (int)numericCha.Value;
            txtRemainingPoints.Text = remainingPoints.ToString();
        }

        private void txtRemainingPoints_TextChanged(object sender, EventArgs e)
        {
            if (remainingPoints < 0)
            {
                btnCreateCharacter.Text = "Spent too many Points!";
                btnCreateCharacter.Enabled = false;
            }
            else
            {
                btnCreateCharacter.Text = "Save";
                btnCreateCharacter.Enabled = true;
            }
        }

        #endregion

        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Must Enter a Name!");
            }
            else
            {
                _name = txtName.Text;
            }

            player = new PlayerCharacter(_name, gender, "", _strength, _dexterity, _consitution, _intelligence, _wisdom, _charisma, imageNumber, 
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0);

            StoryProgression newStory = new StoryProgression(false, 9);
            World world = new World(player, 12, 1050, "");

			SaveLoad.SavePlayerDetailsToFile(player);
			SaveLoad.SaveWorldDetailsToFile(player, world);
			SaveLoad.SaveStoryProgressionToFile(player, newStory);

			SaveLoad.SaveRelationshipToFile(player, new Mother());
			SaveLoad.SaveRelationshipToFile(player, new Sister());
			SaveLoad.LoadAllRelationships(player);

            this.Close();
            if (txtName.Enabled)
            {
                WorldUI newVisibleWorld = new WorldUI(player, world, parentForm, newStory);
                newVisibleWorld.Show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
			NextPic(gender);
        }

		private void btnPreviousPic_Click(object sender, EventArgs e)
		{
			PreviousPic(gender);
		}

		private void NextPic(int gender)
		{
			if (imageNumber == HelperClass.Images(gender).Count() - 1)
			{
				imageNumber = 0;
			}
			else
			{
				imageNumber++;
			}
			pBoxImage.Image = HelperClass.Images(gender)[imageNumber];
		}

		private void PreviousPic(int gender)
		{
			if (imageNumber == 0)
			{
				imageNumber = HelperClass.Images(gender).Count() - 1;
			}
			else
			{
				imageNumber--;
			}
			pBoxImage.Image = HelperClass.Images(gender)[imageNumber];

		}

        private void btnReset_Click(object sender, EventArgs e)
        {
            numericStr.Value = 10;
            numericDex.Value = 10;
            numericCon.Value = 10;
            numericInt.Value = 10;
            numericWis.Value = 10;
            numericCha.Value = 10;
            remainingPoints = 10;
        }

        private void Character_Creation_FormClosed(object sender, FormClosedEventArgs e)
        {
			parentForm.Show();
        }

        private void cBoxGender_SelectedValueChanged(object sender, EventArgs e)
        {
			if (cBoxGender.Text == "Male")
			{
				gender = 1;
			}
			else
			{
				gender = 0;
			}
			pBoxImage.Image = HelperClass.Images(gender)[0];
			imageNumber = 0;
			txtName.Text = "";
        }
    }
}
