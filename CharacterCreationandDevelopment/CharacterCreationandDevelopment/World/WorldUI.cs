using CharacterCreationandDevelopment.Characters;
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
        private StoryProgression storyProgression;
        private bool wc = false;

        public WorldUI(PlayerCharacter player, World world, Form parentForm, StoryProgression storyProgression)
        {
            InitializeComponent();
            parentForm.Hide();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.player = player;
            this.storyProgression = storyProgression;
            this.world = world;

			//Startup
            SetStartLocation();
            pBoxMood.Image = player.CurrentMood.GetMoodImage();
			pBoxPortrait.Image = HelperClass.Images(player.gender)[player.portraitNumber];
			lblDate.Text = world.GetDate();
        }

		private void RunConversation(IConversation currentConversation)
		{
			world.SetConversation(currentConversation);
			world.LogEventConversation(currentConversation.GetEventConversation());
			ConversationDialog eventConversationDialog = new ConversationDialog(currentConversation, player);
			eventConversationDialog.ShowDialog();
		}


		private void RunEvent(IEvent currentEvent)
		{
			world.SetEvent(currentEvent);
			RunConversation(currentEvent);

			if (currentEvent.eventChoices.Count == 2)
			{
				eventDecisionBox = new EventDecisionBox(currentEvent.EventDecisionText(), currentEvent.eventChoices[0], currentEvent.eventChoices[1]);
			}
			else if (currentEvent.eventChoices.Count == 3)
			{
				eventDecisionBox = new EventDecisionBox(currentEvent.EventDecisionText(), currentEvent.eventChoices[0], currentEvent.eventChoices[1], currentEvent.eventChoices[2]);
			}
			eventDecisionBox.ShowDialog();

			List<string> eventOutcomeList = new List<string>();
			
			eventOutcomeList = world.EventDecision(eventDecisionBox.choice);
			EventOutcome eventOutcome = new EventOutcome(eventOutcomeList);
			world.LogEventConversation(eventOutcomeList);
			eventOutcome.ShowDialog();
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
			YearOne();
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

        private void lblRelationships_MouseEnter(object sender, EventArgs e)
        {
            lblRelationships.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void lblRelationships_MouseLeave(object sender, EventArgs e)
        {
            lblRelationships.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
		#endregion

		#region ChangeLocation

        private void ChangeLocation(Location location)
        {
            player.location = location.locationName;
            lblCurrentLocation.Text = location.locationName;
            lBoxActions.Items.Clear();
            foreach (string action in location.GetActions(player))
            {
                lBoxActions.Items.Add(action);
            }
        }

        private void SetStartLocation()
        {
            switch (player.location)
            {
                case "The Church":
                    ChangeLocation(new Church());
                    break;
                case "The Farm":
                    ChangeLocation(new Farm());
                    break;
                case "The School":
                    ChangeLocation(new School());
                    break;
                case "The Lake":
                    ChangeLocation(new Lake());
                    break;
                case "The Barracks":
                    ChangeLocation(new Barracks());
                    break;
                case "The Market":
                    ChangeLocation(new Market());
                    break;
                case "The Blacksmith":
                    ChangeLocation(new Blacksmith());
                    break;
                case "The Forest Path":
                    ChangeLocation(new ForestPath());
                    break;
                default:
                    ChangeLocation(new Farm());
                    break;
            }
        }

		private void pBoxChurch_Click(object sender, EventArgs e)
        {
            ChangeLocation(new Church());
        }

        private void pBoxFarm_Click(object sender, EventArgs e)
        {
            ChangeLocation(new Farm());
         }

        private void pBoxSchool_Click(object sender, EventArgs e)
        {
            ChangeLocation(new School());
        }

        private void pBoxLake_Click(object sender, EventArgs e)
        {
            ChangeLocation(new Lake());
        }

        private void pBoxBarracks_Click(object sender, EventArgs e)
        {
            ChangeLocation(new Barracks());
        }

        private void pBoxMarket_Click(object sender, EventArgs e)
        {
            ChangeLocation(new Market());
        }

        private void pBoxBlacksmith_Click(object sender, EventArgs e)
        {
            ChangeLocation(new Blacksmith());
        }

        private void pBoxForestPath_Click(object sender, EventArgs e)
        {
            ChangeLocation(new ForestPath());
        }
		#endregion

		#region Actions

		private void TakeAction(ILesson lesson, params string[] keywords)
		{
			foreach (string keyword in keywords)
			{
				if (lBoxActions.SelectedItem.ToString().Contains(keyword))
				{
					player.SetLesson(lesson);
					txtConversation.Text = world.AddJournalEntry(lesson.LessonEffects());
					NextTurn();
				}
                if (lBoxActions.SelectedItem.ToString().Contains("Cow"))
                {
                    player.animalEmpathy -= 10;
                    if (player.animalEmpathy < 0)
                        player.animalEmpathy = 0;
                }
			}
		}

		private void SetToolTipValue(ILesson lesson, params string[] keywords)
		{
			foreach (string keyword in keywords)
			{
				if (lBoxActions.SelectedItem.ToString().Contains(keyword))
				{
					this.toolTip1.SetToolTip(lBoxActions, lesson.GetToolTip());
				}
			}
		}

		public void RunActionMethod(DelegateWorldActions ActionOrToolTip)
		{
			ActionOrToolTip(new AnimalEmpathyLesson(player), "Farm", "Animals");
			ActionOrToolTip(new CraftingLesson(player), "Create");
            ActionOrToolTip(new ClimbingLesson(player), "Climb");
			ActionOrToolTip(new DiplomacyLesson(player),"Barter");
			ActionOrToolTip(new FaithLesson(player),"Prayer");
			ActionOrToolTip(new HelpingAroundTheHouse(player), "Help Mum");
			ActionOrToolTip(new LockpickingLesson(player),"Break in");
			ActionOrToolTip(new MedicineLesson(player), "Medic");
			ActionOrToolTip(new PickpocketingLesson(player),"Steal");
            ActionOrToolTip(new RunningLesson(player), "Run");
			ActionOrToolTip(new ScienceLesson(player),"Science");
			ActionOrToolTip(new SurvivalLesson(player),"Survival", "Camping");
			ActionOrToolTip(new SwimmingLesson(player),"Swim");
			ActionOrToolTip(new UnarmedLesson(player),"Fist", "Punch");
			ActionOrToolTip(new WeaponsLesson(player),"Weapon");
            ActionOrToolTip(new NoLesson(player),"Relax");
		}

        private void YearOne()
        {
            if (HelperClass.GetRelationshipFromList("Mother").opinionofPlayer < 50)
            {
                if (!storyProgression.firstConversation)
                {
                    RunConversation(new FirstConversation(player));
                    storyProgression.firstConversation = true;
                }
            }
			
			if ((player.ageYears > 9) && (player.ageMonths > 6) && (storyProgression.wolfEvent == 9))
			{
                if (!wc)
                {
                    RunConversation(new WolfConversation(player));
                    wc = true;
                }

				if (player.location == "The Forest Path")
				{
					storyProgression.wolfEvent = 0;
					RunEvent(new PlayingWolfEvent(player));
					storyProgression.wolfEvent = eventDecisionBox.choice;
				}
			}
        }

		private void btnTakeAction_Click(object sender, EventArgs e)
		{
			if (lBoxActions.SelectedItem == null)
			{
				MessageBox.Show("Select an Action");
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
			playerSkills.ShowDialog();
		}
		#endregion

		private void WorldUI_FormClosed(object sender, FormClosedEventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Would you like to save the game?", "World Closing", MessageBoxButtons.YesNo);
			if (dialogResult.ToString() == "Yes")
			{
				SaveGame();
			}
			HelperClass.listOfRelationships.Clear();
			Form1 x = new Form1();
			x.Show();
		}

		private void SaveGame()
		{
			foreach (Relationship relationship in HelperClass.listOfRelationships)
			{
				SaveLoad.SaveRelationshipToFile(player, relationship);
			}
			SaveLoad.SavePlayerDetailsToFile(player);
			SaveLoad.SaveWorldDetailsToFile(player, world);
			SaveLoad.SaveStoryProgressionToFile(player, storyProgression);
		}

		private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveGame();
			MessageBox.Show("Game Saved");
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void lblRelationships_Click(object sender, EventArgs e)
        {
            RelationshipsUI relationshipsUI = new RelationshipsUI(player);
            relationshipsUI.ShowDialog();
        }




    }
}
