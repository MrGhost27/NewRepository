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
        private bool isMale;
        public PlayerCharacter player;
        private Form parentForm;

        public Character_Creation(Form parentForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.parentForm = parentForm;
            isMale = true;
            SetAttributes();
            imageNumber = 0;
            pBoxImage.Image = HelperClass.MaleImages()[imageNumber];
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
            pBoxImage.Image = HelperClass.MaleImages()[player.portraitNumber];

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
            RandomName(isMale);
        }

        private void RandomName(bool isMale)
        {
            if (isMale)
            {
                txtName.Text = HelperClass.RandomMaleName();
                _name = txtName.Text;
            }
            else
            {
                txtName.Text = HelperClass.RandomFemaleName();
                _name = txtName.Text;
            }
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

            player = new PlayerCharacter(_name, _strength, _dexterity, _consitution, _intelligence, _wisdom, _charisma, imageNumber, 
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 0, 100, -50, 50 , -25);

			HelperClass.SavePlayerDetailsToFile(player);
            this.Close();
            if (txtName.Enabled)
            {
                WorldUI newVisibleWorld = new WorldUI(player, parentForm);
                newVisibleWorld.Show();
            }
        

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextPic(isMale);
        }

        private void NextPic(bool isMale)
        {
            if (isMale)
            {
                if (imageNumber == HelperClass.MaleImages().Count() - 1)
                {
                    imageNumber = 0;
                }
                else
                {
                    imageNumber++;
                }
                pBoxImage.Image = HelperClass.MaleImages()[imageNumber];
            }
            else
            {
                if (imageNumber == HelperClass.FemaleImages().Count() - 1)
                {
                    imageNumber = 0;
                }
                else
                {
                    imageNumber++;
                }
                pBoxImage.Image = HelperClass.FemaleImages()[imageNumber];
            }

        }

        private void PreviousPic(bool isMale)
        {
            if (isMale)
            {
                if (imageNumber == 0)
                {
                    imageNumber = HelperClass.MaleImages().Count() - 1;
                }
                else
                {
                    imageNumber--;
                }
                pBoxImage.Image = HelperClass.MaleImages()[imageNumber];
            }
            else
            {
                if (imageNumber == 0)
                {
                    imageNumber = HelperClass.FemaleImages().Count() - 1;
                }
                else
                {
                    imageNumber--;
                }
                pBoxImage.Image = HelperClass.FemaleImages()[imageNumber];
            }
        }

        private void btnPreviousPic_Click(object sender, EventArgs e)
        {
            PreviousPic(isMale);
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
                isMale = true;
                pBoxImage.Image = HelperClass.MaleImages()[0];
                txtName.Text = "";
            }
            else if (cBoxGender.Text == "Female")
            {
                isMale = false;
                pBoxImage.Image = HelperClass.FemaleImages()[0];
                txtName.Text = "";
            }
            else
            {
                MessageBox.Show("Not a valid Gender");
            }
        }







    }
}
