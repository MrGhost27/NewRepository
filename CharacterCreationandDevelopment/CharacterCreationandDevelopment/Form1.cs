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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Character_Creation CharCreation = new Character_Creation();
            CharCreation.Show();
            this.Hide();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
    }
}
