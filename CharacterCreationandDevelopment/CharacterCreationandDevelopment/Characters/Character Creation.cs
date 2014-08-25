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
    public partial class Character_Creation : Form
    {
        private int remainingPoints;
        private int _strength;
        private int _dexterity;
        private int _constitution;
        private int _intelligence;
        private int _wisdom;
        private int _charisma;
        private string _name;
        private int imageNumber;

        public Character_Creation()
        {
            InitializeComponent();
            imageNumber = 0;
            pBoxImage.Image = HelperClass.Images()[imageNumber];
            remainingPoints = 10;
            txtRemainingPoints.Text = remainingPoints.ToString();

            _strength = (int)numericUpDown1.Value;
            _dexterity = (int)numericUpDown2.Value;
            _constitution = (int)numericUpDown3.Value;
            _intelligence = (int)numericUpDown4.Value;
            _wisdom = (int)numericUpDown5.Value;
            _charisma = (int)numericUpDown6.Value;
            _name = txtName.Text;
        }

        private void buttonRandomName_Click(object sender, EventArgs e)
        {
            txtName.Text = HelperClass.RandomName();
            _name = txtName.Text;
        }

        #region ValueChanged
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

            remainingPoints += _constitution - (int)numericUpDown3.Value;
            _constitution = (int)numericUpDown3.Value;
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
                btnCreateCharacter.Visible = false;
            }
            else
            {
                btnCreateCharacter.Visible = true;
            }
        }

        #endregion

        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            if (txtName.Text == null)
            {
                _name = HelperClass.RandomName();
            }
           HelperClass.Images().Remove(pBoxImage.Image);

           PlayerCharacter.name = _name;
           PlayerCharacter.portrait = pBoxImage.Image;
           PlayerCharacter.maxHP = 100;
           PlayerCharacter.currentHP = PlayerCharacter.maxHP;
           PlayerCharacter.strength = _strength;
           PlayerCharacter.dexterity = _dexterity;
           PlayerCharacter.constitution = _constitution;
           PlayerCharacter.intelligence = _intelligence;
           PlayerCharacter.wisdom = _wisdom;
           PlayerCharacter.charisma = _charisma;
           this.Close();
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
