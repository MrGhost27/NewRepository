using CharacterCreationandDevelopment.Events_and_Conversations;
using CharacterCreationandDevelopment.Lessons;
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

        public WorldUI(PlayerCharacter playerInWorld)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.player = playerInWorld;
            world = new World(player);
            this.player = HelperClass.LoadPlayerDetailsFromFile(player.name);
            pictureBox1.Image = HelperClass.Images()[player.portraitNumber];
            lblDate.Text = world.GetDate();
            listofActions = new List<String>();
        }

        private void RunEvent(IEvent thisevent)
        {
            MessageBox.Show("Suddenly someone comes over to you...");
            world.SetEvent(thisevent);
            pBoxNPC.Image = world.newevent.eventNPC.portrait;
            txtConversation.AppendText(world.GetDate() + ": " + world.newevent.EventConversation() + Environment.NewLine);
            DialogResult dialogResult = MessageBox.Show("Make a Choice", "Choice Time", MessageBoxButtons.YesNo);
            txtConversation.AppendText(world.GetDate() + ": " + world.newevent.MakeChoice(dialogResult.ToString()) + Environment.NewLine);
            CloseEvent();
        }

        /*private void GainLesson(ILesson todaysLesson)
        {
            world.SetLesson(todaysLesson);
            txtConversation.AppendText(world.GetDate() + ": " + world.lesson.LessonEffects() + Environment.NewLine);
            NextTurn();
        }*/

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
            this.player = HelperClass.LoadPlayerDetailsFromFile(player.name);
            Character_Creation CharacterSheet = new Character_Creation(player, 0);
            CharacterSheet.ShowDialog();
        }

        private void NextTurn()
        {
            lblDate.Text = world.NewTurn();

            if (world.monthNumber == 3)
            {
                RunEvent((new GameStart(player)));
            }
        }

        private void btnNextTurn_Click(object sender, EventArgs e)
        {
            NextTurn();
        }

        /*private void btnStartTraining_Click(object sender, EventArgs e)
        {
            GainLesson(new WeaponsLesson(player));
        }*/

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
            PopulateListBox();
        }

        private void pBoxFarm_Click(object sender, EventArgs e)
        {
            lblCurrentLocation.Text = "Your Home";
            listofActions.Clear();
            listofActions.Add("Work with the animals");
            PopulateListBox();
        }

        private void pBoxSchool_Click(object sender, EventArgs e)
        {
            lblCurrentLocation.Text = "The School";
            listofActions.Clear();
            listofActions.Add("Take Science Class");
            listofActions.Add("Take Medicine Class");
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
    }
}
