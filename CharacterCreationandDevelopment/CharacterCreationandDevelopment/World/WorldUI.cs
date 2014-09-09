using CharacterCreationandDevelopment.Events_and_Conversations;
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
        private EventDecisionBox eventDecisionBox;

        public WorldUI(PlayerCharacter player, Form parentForm)
        {
            InitializeComponent();
            parentForm.Hide();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.player = player;
            world = new World(player);

			//Startup
			ChangeLocation("Your Home", "Work on the Farm", "Relax at Home");
            pBoxMood.Image = player.CurrentMood.GetMoodImage();
			pBoxPortrait.Image = HelperClass.Images(player.gender)[player.portraitNumber];
			lblDate.Text = world.GetDate();
        }

		private void RunConversation(IConversation currentConversation)
		{
			world.SetConversation(currentConversation);
			world.LogEventConversation();
			ConversationDialog eventConversationDialog = new ConversationDialog(currentConversation, player);
			eventConversationDialog.ShowDialog();
		}


        private void RunEvent(IEvent currentEvent)
        {
			world.SetEvent(currentEvent);
			RunConversation(currentEvent);
			//pBoxNPC.Visible = true;
			//pBoxNPC.Image = thisevent.conversationNPC.portrait;

			if (currentEvent.eventChoices.Count == 2)
			{
				eventDecisionBox = new EventDecisionBox(currentEvent.EventDecisionText(), currentEvent.eventChoices[0], currentEvent.eventChoices[1]);
			}
			else
			{
				eventDecisionBox = new EventDecisionBox(currentEvent.EventDecisionText(), currentEvent.eventChoices[0], currentEvent.eventChoices[1], currentEvent.eventChoices[2]);
			}
			eventDecisionBox.ShowDialog();

     		txtConversation.Text = world.EventDecision(eventDecisionBox.choice);
            CloseEvent();
        }
		
        private void CloseEvent()
        {
            pBoxNPC.Visible = false;
            NextTurn();
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

            if ((player.ageYears == 10) && (player.ageMonths == 9))
            {
                RunEvent((new ChildhoodStart(player)));
            }
        }

		#region MouseEvents

		private void pBoxMood_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(this.pBoxMood, player.CurrentMood.GetName());
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
		#endregion

		#region ChangeLocation

		private void ChangeLocation(string locationName, params string[] actionList)
		{
			player.location = locationName;
			lblCurrentLocation.Text = locationName;
			lBoxActions.Items.Clear();
			for (int i = 0; i < actionList.Length; i++)
			{
				lBoxActions.Items.Add(actionList[i]);
			}
		}

		private void pBoxChurch_Click(object sender, EventArgs e)
        {
			ChangeLocation("The Church", "Go for Prayer", "Break into the Church");
        }

        private void pBoxFarm_Click(object sender, EventArgs e)
        {
			ChangeLocation("Your Home", "Work on the Farm", "Relax at Home");
         }

        private void pBoxSchool_Click(object sender, EventArgs e)
        {
			ChangeLocation("The School", "Take Science Class", "Take Medical Class", "Break into the School");
        }

        private void pBoxLake_Click(object sender, EventArgs e)
        {
			ChangeLocation("The Lake", "Go Swimming", "Go Camping");
        }

        private void pBoxBarracks_Click(object sender, EventArgs e)
        {
			ChangeLocation("The Barracks", "Go Running", "Train With Medics", "Train With Fists", "Train With Weapons",
				"Take Survival Training");
        }

        private void pBoxMarket_Click(object sender, EventArgs e)
        {
			ChangeLocation("The Market", "Barter for Food", "Steal Food");
        }

        private void pBoxBlacksmith_Click(object sender, EventArgs e)
        {
			ChangeLocation("The Blacksmith", "Barter for Items", "Steal Items", "Create Items", "Break In");
        }
		#endregion

		#region Actions

		private void TakeAction(string keyword, ILesson lesson)
		{
			if (lBoxActions.SelectedItem.ToString().Contains(keyword))
			{
				player.SetLesson(lesson);
				txtConversation.Text = world.AddJournalEntry(lesson.LessonEffects());
				NextTurn();
			}
		}

		private void SetToolTipValue(string keyword, ILesson lesson)
		{
			if (lBoxActions.SelectedItem.ToString().Contains(keyword))
			{
				this.toolTip1.SetToolTip(lBoxActions, lesson.GetToolTip());
			}
		}

		public void RunActionMethod(DelegateWorldActions ActionOrToolTip)
		{
			ActionOrToolTip("Farm", new AnimalEmpathyLesson(player));
			ActionOrToolTip("Running", new AthleticsLesson(player));
			ActionOrToolTip("Create", new CraftingLesson(player));
			ActionOrToolTip("Barter", new DiplomacyLesson(player));
			ActionOrToolTip("Prayer", new FaithLesson(player));
			ActionOrToolTip("Break", new LockpickingLesson(player));
			ActionOrToolTip("Medic", new MedicineLesson(player));
			ActionOrToolTip("Steal", new PickpocketingLesson(player));
			ActionOrToolTip("Science", new ScienceLesson(player));
			ActionOrToolTip("Survival", new SurvivalLesson(player));
			ActionOrToolTip("Camping", new SurvivalLesson(player));
			ActionOrToolTip("Swimming", new SwimmingLesson(player));
			ActionOrToolTip("Fist", new UnarmedLesson(player));
			ActionOrToolTip("Weapon", new WeaponsLesson(player));
		}

		private void btnTakeAction_Click(object sender, EventArgs e)
		{
			if (lBoxActions.SelectedItem == null)
			{
				MessageBox.Show("Select an Action");
			}
			else if (lBoxActions.SelectedItem.ToString().Contains("Relax"))
			{
				player.SetExcitedBored(-50);
                if (!player.firstConversation)
                {
                    RunConversation(new FirstConversation(player));
                    player.firstConversation = true;
                }
				txtConversation.Text = world.AddJournalEntry(player.name + " does nothing all month");
				NextTurn();
			}
			else
			{
				RunActionMethod(TakeAction);
			}
		}

		private void lBoxActions_SelectedValueChanged(object sender, EventArgs e)
		{
            if (lBoxActions.SelectedItem == null)
            {

            }
            else if (lBoxActions.SelectedItem.ToString().Contains("Relax"))
            {
                this.toolTip1.SetToolTip(lBoxActions, "Skill Bonus: What Skill?. Makes you Bored. Very Bored.");
            }
            else
            {
				RunActionMethod(SetToolTipValue);
            }
		}
		#endregion

		#region OpenOtherForms

		private void pBoxPortrait_Click(object sender, EventArgs e)
		{
			Character_Creation CharacterSheet = new Character_Creation(player, 0, this);
			CharacterSheet.ShowDialog();
		}

		private void lblJournal_Click(object sender, EventArgs e)
		{
			JournalUI journalUI = new JournalUI(world);
			journalUI.ShowDialog();
		}

        private void lblMood_Click(object sender, EventArgs e)
        {
            MoodUI2 moodUI = new MoodUI2(player);
            moodUI.ShowDialog();
        }

		private void lblSkills_Click(object sender, EventArgs e)
		{
			playerSkills = new Skills(player, this);
			playerSkills.Show();
			this.Hide();
		}
		#endregion

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





    }
}
