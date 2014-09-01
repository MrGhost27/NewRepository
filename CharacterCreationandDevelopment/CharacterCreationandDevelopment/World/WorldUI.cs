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

        public WorldUI(PlayerCharacter playerInWorld)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.player = playerInWorld;
            world = new World(player);
            this.player = HelperClass.LoadPlayerDetailsFromFile(player.name);
            pictureBox1.Image = HelperClass.Images()[player.portraitNumber];
            lblDate.Text = world.GetDate();
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

        private void GainLesson(ILesson todaysLesson)
        {
            world.SetLesson(todaysLesson);
            MessageBox.Show(player.name + " goes to " + world.lesson.GetLessonName());
            txtConversation.AppendText(world.GetDate() + ": " + world.lesson.LessonEffects() + Environment.NewLine);
            NextTurn();
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

        private void button1_Click(object sender, EventArgs e)
        {
            GainLesson(new WeaponsLesson(player));
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GainLesson(new FaithLesson(player));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GainLesson(new AnimalEmpathyLesson(player));
        }

		private void pBoxFarm_MouseEnter(object sender, EventArgs e)
		{
		}
    }
}
