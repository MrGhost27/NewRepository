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
    public partial class Skills : Form
    {
        private PlayerCharacter player;
        private Form parentForm;

        public Skills(PlayerCharacter player, Form parentForm)
        {
            InitializeComponent();
            this.player = player;
            this.parentForm = parentForm;
            this.StartPosition = FormStartPosition.CenterScreen;
            PopulateSkills();
        }

        private void PopulateSkills()
        {
            lblAnimalEmpathyValue.Text = player.animalEmpathy.ToString();
            lblAthleticsValue.Text = player.athletics.ToString();
            lblCraftingValue.Text = player.crafting.ToString();
            lblDiplomacyValue.Text = player.diplomacy.ToString();
            lblFaithValue.Text = player.faith.ToString();
            lblLockpickingValue.Text = player.lockpicking.ToString();
            lblMedicineValue.Text = player.medicine.ToString();
            lblPickpocketingValue.Text = player.pickpocketing.ToString();
            lblScienceValue.Text = player.science.ToString();
            lblSurvivalValue.Text = player.survival.ToString();
            lblSwimmingValue.Text = player.swimming.ToString();
            lblUnarmedValue.Text = player.unarmed.ToString();
            lblWeaponsValue.Text = player.weapons.ToString();
            
        }

        private void Skills_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }
    }
}
