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
            UpdateSkillsAndProgressBars(pBarAnimalEmpathy, lblAnimalEmpathyValue, player.animalEmpathy);
            UpdateSkillsAndProgressBars(pBarAthletics, lblAthleticsValue, player.athletics);
            UpdateSkillsAndProgressBars(pBarCrafting, lblCraftingValue, player.crafting);
            UpdateSkillsAndProgressBars(pBarDiplomacy, lblDiplomacyValue, player.diplomacy);
            UpdateSkillsAndProgressBars(pBarFaith, lblFaithValue, player.faith);
            UpdateSkillsAndProgressBars(pBarLockpicking, lblLockpickingValue, player.lockpicking);
            UpdateSkillsAndProgressBars(pBarMedicine, lblMedicineValue, player.medicine);
            UpdateSkillsAndProgressBars(pBarPickpocketing, lblPickpocketingValue, player.pickpocketing);
            UpdateSkillsAndProgressBars(pBarScience, lblScienceValue, player.science);
            UpdateSkillsAndProgressBars(pBarSurvival, lblSurvivalValue, player.survival);
            UpdateSkillsAndProgressBars(pBarSwimming, lblSwimmingValue, player.swimming);
            UpdateSkillsAndProgressBars(pBarUnarmed, lblUnarmedValue, player.unarmed);
            UpdateSkillsAndProgressBars(pBarWeapons, lblWeaponsValue, player.weapons);
        }

        private void UpdateSkillsAndProgressBars(ProgressBar progressBar, Label label, int skill)
        {
            if (skill > 100)
            {
                skill = 100;
            }
            progressBar.Value = skill;
            label.Text = skill.ToString();
        }

        private void Skills_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }
    }
}
