using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreationandDevelopment.Events_and_Conversations
{
    public partial class EventDecisionBox : Form
    {
        public int choice { get; private set; }

        public EventDecisionBox(string DecisionInfo, string ChoiceText1, string ChoiceText2)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            choice = 0;
            lblDecisionInfo.Text = DecisionInfo;
            btnChoice1.Text = ChoiceText1;
            btnChoice2.Text = ChoiceText2;
            btnChoice3.Visible = false;
        }

        public EventDecisionBox(string DecisionInfo, string ChoiceText1, string ChoiceText2, string ChoiceText3)
        {
            InitializeComponent();
            lblDecisionInfo.Text = DecisionInfo;
            btnChoice1.Text = ChoiceText1;
            btnChoice2.Text = ChoiceText2;
            btnChoice3.Text = ChoiceText3;
            btnChoice3.Visible = true;

        }

        private void btnChoice1_Click(object sender, EventArgs e)
        {
            choice = 1;
            this.Hide();
        }

        private void btnChoice2_Click(object sender, EventArgs e)
        {
            choice = 2;
            this.Hide();
        }

        private void btnChoice3_Click(object sender, EventArgs e)
        {
            choice = 3;
            this.Hide();
        }
    }
}
