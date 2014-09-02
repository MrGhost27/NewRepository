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
        public PlayerCharacter player;

        public Character_Creation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SetAttributes();
            imageNumber = 0;
            pBoxImage.Image = HelperClass.Images()[imageNumber];
            remainingPoints = 10;
            txtRemainingPoints.Text = remainingPoints.ToString();
       }

        public Character_Creation(PlayerCharacter player, int PointsToAllocate)
        {
            InitializeComponent();
            SetAttributes();
            this.Text = "Character Sheet";
            btnCreateCharacter.Text = "Level Up";
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
            pBoxImage.Image = HelperClass.Images()[player.portraitNumber];

            if (PointsToAllocate == 0)
            {
                numericStr.Enabled = false;
                numericDex.Enabled = false;
                numericCon.Enabled = false;
                numericInt.Enabled = false;
                numericWis.Enabled = false;
                numericCha.Enabled = false;
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
            txtName.Text = HelperClass.RandomName();
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
                _name = HelperClass.RandomName();
            }
            else
            {
                _name = txtName.Text;
            }

            player = new PlayerCharacter(_name, _strength, _dexterity, _consitution, _intelligence, _wisdom, _charisma, imageNumber, 
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);


            HelperClass.SavePlayerDetailsToFile(player);
            this.Close();
            if (txtName.Enabled)
            {
                WorldUI newVisibleWorld = new WorldUI(player);
                newVisibleWorld.Show();
            }
        

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (imageNumber == HelperClass.Images().Count())
            {
                imageNumber = 0;
            }
            else
            {
                imageNumber++;
            }
            pBoxImage.Image = HelperClass.Images()[imageNumber];
        }

        private void btnPreviousPic_Click(object sender, EventArgs e)
        {
            if (imageNumber == 0)
            {
                imageNumber = HelperClass.Images().Count()-1;
            }
            else
            {
                imageNumber--;
            }
            pBoxImage.Image = HelperClass.Images()[imageNumber];
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







    }
}
