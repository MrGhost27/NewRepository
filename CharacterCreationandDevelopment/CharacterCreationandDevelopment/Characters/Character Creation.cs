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
            imageNumber = 0;
            pBoxImage.Image = HelperClass.Images()[imageNumber];
            remainingPoints = 10;
            txtRemainingPoints.Text = remainingPoints.ToString();

            _strength = (int)numericUpDown1.Value;
            _dexterity = (int)numericUpDown2.Value;
            _consitution = (int)numericUpDown3.Value;
            _intelligence = (int)numericUpDown4.Value;
            _wisdom = (int)numericUpDown5.Value;
            _charisma = (int)numericUpDown6.Value;
            _name = txtName.Text;
        }

        public Character_Creation(PlayerCharacter player, int PointsToAllocate)
        {
            InitializeComponent();
            this.Text = "Character Sheet";
            btnCreateCharacter.Text = "Level Up";
            txtName.Text = player.name;
            txtName.Enabled = false;
            btnPreviousPic.Enabled = false;
            btnNext.Enabled = false;
            btnReset.Visible = false;
            buttonRandomName.Visible = false;


            numericUpDown1.Value = player.strength;
            numericUpDown2.Value = player.dexterity;
            numericUpDown3.Value = player.constitution;
            numericUpDown4.Value = player.intelligence;
            numericUpDown5.Value = player.wisdom;
            numericUpDown6.Value = player.charisma;
            imageNumber = player.portraitNumber;
            pBoxImage.Image = HelperClass.Images()[player.portraitNumber];

            if (PointsToAllocate == 0)
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
                numericUpDown6.Enabled = false;
                remainingPoints = 0;
                btnCreateCharacter.Visible = false;
            }
            else
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = true;
                numericUpDown5.Enabled = true;
                numericUpDown6.Enabled = true;
                remainingPoints = PointsToAllocate;
                btnCreateCharacter.Visible = true;
            }
            txtRemainingPoints.Text = remainingPoints.ToString();
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
            if (numericUpDown1.Value < 5)
            {
                numericUpDown1.Value = 5;
            }

            remainingPoints += _strength - (int)numericUpDown1.Value;
            _strength = (int)numericUpDown1.Value;
            txtRemainingPoints.Text = remainingPoints.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value < 5)
            {
                numericUpDown2.Value = 5;
            }

            remainingPoints += _dexterity - (int)numericUpDown2.Value;
            _dexterity = (int)numericUpDown2.Value;
            txtRemainingPoints.Text = remainingPoints.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value < 5)
            {
                numericUpDown3.Value = 5;
            }

            remainingPoints += _consitution - (int)numericUpDown3.Value;
            _consitution = (int)numericUpDown3.Value;
            txtRemainingPoints.Text = remainingPoints.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value < 5)
            {
                numericUpDown4.Value = 5;
            }

            remainingPoints += _intelligence - (int)numericUpDown4.Value;
            _intelligence = (int)numericUpDown4.Value;
            txtRemainingPoints.Text = remainingPoints.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown5.Value < 5)
            {
                numericUpDown5.Value = 5;
            }

            remainingPoints += _wisdom - (int)numericUpDown5.Value;
            _wisdom = (int)numericUpDown5.Value;
            txtRemainingPoints.Text = remainingPoints.ToString();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown6.Value < 5)
            {
                numericUpDown6.Value = 5;
            }

            remainingPoints += _charisma - (int)numericUpDown6.Value;
            _charisma = (int)numericUpDown6.Value;
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
                btnCreateCharacter.Text = "Create Character";
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
            
            player = new PlayerCharacter(_name, _strength, _dexterity, _consitution, _intelligence, _wisdom, _charisma, imageNumber);
            HelperClass.SavePlayerDetailsToFile(player);
            this.Close();
            WorldUI newVisibleWorld = new WorldUI(player);
            newVisibleWorld.Show();

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
                imageNumber = HelperClass.Images().Count();
            }
            else
            {
                imageNumber--;
            }
            pBoxImage.Image = HelperClass.Images()[imageNumber];
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 10;
            numericUpDown2.Value = 10;
            numericUpDown3.Value = 10;
            numericUpDown4.Value = 10;
            numericUpDown5.Value = 10;
            numericUpDown6.Value = 10;
            remainingPoints = 10;
        }







    }
}
