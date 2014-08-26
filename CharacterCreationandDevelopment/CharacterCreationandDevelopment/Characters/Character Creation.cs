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
            if (txtName.Text == "")
            {
                _name = HelperClass.RandomName();
            }
           /*Probably correct
            * HelperClass.Images().Remove(pBoxImage.Image);
            */

            HelperClass.SavePlayerDetailsToFile(_name, this);
            HelperClass.LoadPlayerDetailsFromFile(_name);
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
