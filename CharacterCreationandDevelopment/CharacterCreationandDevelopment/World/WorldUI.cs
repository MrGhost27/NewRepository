﻿using CharacterCreationandDevelopment.Events_and_Conversations;
using CharacterCreationandDevelopment.Lessons;
using CharacterCreationandDevelopment.Moods;
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
    public partial class WorldUI : Form
    {
        private PlayerCharacter player;
        private World world;
        private Skills playerSkills;
        private List<String> listofActions;
        private EventDecisionBox eventDecisionBox;

        public WorldUI(PlayerCharacter playerInWorld, Form parentForm)
        {
            InitializeComponent();
            parentForm.Hide();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.player = playerInWorld;
            world = new World(player);

            pictureBox1.Image = HelperClass.Images()[player.portraitNumber];
            lblDate.Text = world.GetDate();
            listofActions = new List<String>();
            AtHome();
        }

        private void RunEvent(IEvent thisevent)
        {
            world.SetEvent(thisevent);
            pBoxNPC.Visible = true;
			pBoxNPC.Image = thisevent.eventNPC.portrait;
			txtConversation.Text = world.EventConversation();
			eventDecisionBox = new EventDecisionBox(thisevent.EventDecisionText(), thisevent.eventChoices[0], thisevent.eventChoices[1]);
            eventDecisionBox.ShowDialog();
			txtConversation.Text = world.EventDecision(eventDecisionBox.choice);
            CloseEvent();
        }
		
        private void CloseEvent()
        {
            pBoxNPC.Visible = false;
            NextTurn();
        }

        private void WorldUI_FormClosed(object sender, FormClosedEventArgs e)
        {
			DialogResult dialogResult = MessageBox.Show("Would you like to save the game?", "World Closing", MessageBoxButtons.YesNo);
			if (dialogResult.ToString() == "Yes")
			{
				HelperClass.SavePlayerDetailsToFile(player);
				HelperClass.SaveWorldDetailsToFile(player, world);
			}
            Form1 x = new Form1();
            x.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Character_Creation CharacterSheet = new Character_Creation(player, 0);
            CharacterSheet.ShowDialog();
        }

        private void NextTurn()
        {
            lblDate.Text = world.NewTurn();
            player.ageMonths++;
            if (player.ageMonths == 13)
            {
                player.ageMonths = 1;
                player.ageYears++;
            }

            player.GetMood();
            pBoxMood.Image = player.CurrentMood.GetMoodImage();

            if (world.monthNumber == 3)
            {
                RunEvent((new GameStart(player)));
            }
        }

        private void lblSkills_Click(object sender, EventArgs e)
        {
            playerSkills = new Skills(player,this);
            playerSkills.Show();
            this.Hide();
        }

        private void lblSkills_MouseEnter(object sender, EventArgs e)
        {
            this.lblSkills.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void lblSkills_MouseLeave(object sender, EventArgs e)
        {
            lblSkills.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

		private void lblJournal_MouseEnter(object sender, EventArgs e)
		{
			lblJournal.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		}

		private void lblJournal_MouseLeave(object sender, EventArgs e)
		{
			lblJournal.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		}

        private void lblMood_MouseEnter(object sender, EventArgs e)
        {
            lblMood.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void lblMood_MouseLeave(object sender, EventArgs e)
        {
            lblMood.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void PopulateListBox()
        {
            lBoxActions.Items.Clear();
            foreach (string action in listofActions)
            {
                lBoxActions.Items.Add(action);
            }
        }

        private void pBoxChurch_Click(object sender, EventArgs e)
        {
            lblCurrentLocation.Text = "The Church";
            listofActions.Clear();
            listofActions.Add("Go for Prayer");
            listofActions.Add("Break into the Church");
            PopulateListBox();
        }

        private void pBoxFarm_Click(object sender, EventArgs e)
        {
            AtHome();
         }

        private void AtHome()
        {
            lblCurrentLocation.Text = "Your Home";
            listofActions.Clear();
            listofActions.Add("Work on the Farm");
            listofActions.Add("Relax at home");
            PopulateListBox();
        }

        private void pBoxSchool_Click(object sender, EventArgs e)
        {
            lblCurrentLocation.Text = "The School";
            listofActions.Clear();
            listofActions.Add("Take Science Class");
            listofActions.Add("Take Medicine Class");
            listofActions.Add("Break into the School");
            PopulateListBox();
        }

        private void pBoxLake_Click(object sender, EventArgs e)
        {
            lblCurrentLocation.Text = "The Lake";
            listofActions.Clear();
            listofActions.Add("Go Swimming");
            listofActions.Add("Go Camping");
            PopulateListBox();
        }

        private void pBoxBarracks_Click(object sender, EventArgs e)
        {
            lblCurrentLocation.Text = "The Barracks";
            listofActions.Clear();
            listofActions.Add("Go Running");
            listofActions.Add("Train with Medics");
            listofActions.Add("Train with Fists");
            listofActions.Add("Train with Weapons");
            listofActions.Add("Take Survival Training");
            PopulateListBox();
        }

        private void pBoxMarket_Click(object sender, EventArgs e)
        {
            lblCurrentLocation.Text = "The Market";
            listofActions.Clear();
            listofActions.Add("Barter for Items");
            listofActions.Add("Steal food");
            PopulateListBox();
        }

        private void pBoxBlacksmith_Click(object sender, EventArgs e)
        {
            lblCurrentLocation.Text = "The Blacksmith";
            listofActions.Clear();
            listofActions.Add("Barter for Items");
            listofActions.Add("Steal Items");
            listofActions.Add("Create Items");
            listofActions.Add("Break in.");
            PopulateListBox();

        }

        private void TakeAction(string keyword, ILesson lesson)
        {
            if (lBoxActions.SelectedItem.ToString().Contains(keyword))
            {
                player.SetLesson(lesson);
				txtConversation.Text = world.AddJournalEntry(lesson.LessonEffects());
                NextTurn();
            }

        }

        private void btnTakeAction_Click(object sender, EventArgs e)
        {
			if (lBoxActions.SelectedItem == null)
			{
				MessageBox.Show("Select an Action");
			}
            else if (lBoxActions.SelectedItem.ToString().Contains("Relax"))
            {
                player.boredAngry += 10;
                txtConversation.Text = world.AddJournalEntry(player.name + " does nothing all month");
                NextTurn();
            }
			else
			{
				TakeAction("Farm", new AnimalEmpathyLesson(player));
				TakeAction("Running", new AthleticsLesson(player));
				TakeAction("Create", new CraftingLesson(player));
				TakeAction("Barter", new DiplomacyLesson(player));
				TakeAction("Prayer", new FaithLesson(player));
				TakeAction("Break", new LockpickingLesson(player));
				TakeAction("Medic", new MedicineLesson(player));
				TakeAction("Steal", new PickpocketingLesson(player));
				TakeAction("Science", new ScienceLesson(player));
				TakeAction("Survival", new SurvivalLesson(player));
				TakeAction("Camping", new SurvivalLesson(player));
				TakeAction("Swimming", new SwimmingLesson(player));
				TakeAction("Fist", new UnarmedLesson(player));
				TakeAction("Weapon", new WeaponsLesson(player));
			}
        }

		private void lblJournal_Click(object sender, EventArgs e)
		{
			JournalUI journalUI = new JournalUI(world);
			journalUI.ShowDialog();
		}

        private void lblMood_Click(object sender, EventArgs e)
        {
            MoodUI moodUI = new MoodUI(player);
            moodUI.ShowDialog();
        }




    }
}
