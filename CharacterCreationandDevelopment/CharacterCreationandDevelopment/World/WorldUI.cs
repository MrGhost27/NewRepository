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

        public WorldUI(PlayerCharacter playerInWorld)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.player = playerInWorld;
            world = new World();
            pictureBox1.Image = HelperClass.Images()[player.portraitNumber];
            lblDate.Text = world.NewTurn();
        }

        private void RunEvent(IEvent thisevent)
        {
            MessageBox.Show("Suddenly someone comes over to you...");
            world.SetEvent(thisevent);
            pBoxNPC.Image = world.newevent.eventNPC.portrait;
            btnNextTurn.Enabled = false;
            txtConversation.AppendText(world.GetDate() + ": " + world.newevent.EventConversation());
            DialogResult dialogResult = MessageBox.Show("Make a Choice", "Choice Time", MessageBoxButtons.YesNo);
            txtConversation.AppendText(world.GetDate() + ": " + world.newevent.MakeChoice(dialogResult.ToString()) + Environment.NewLine);
            CloseEvent();
        }

        private void GoToSchool(ILesson todaysLesson)
        {
            world.SetLesson(todaysLesson);
            MessageBox.Show(player.name + " goes to " + world.lesson.GetLessonName());
            txtConversation.AppendText(world.GetDate() + ": " + world.lesson.LessonEffects() + Environment.NewLine);
            NextTurn();
        }

        private void CloseEvent()
        {
            pBoxNPC.Visible = false;
            btnNextTurn.Enabled = true;
            NextTurn();
        }

        private void WorldUI_FormClosed(object sender, FormClosedEventArgs e)
        {
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
            label1.Text = "Weapons: " + player.weapons;

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
            GoToSchool(new WeaponsLesson(player));
            progressBar1.Value = player.weapons;
        }
    }
}
