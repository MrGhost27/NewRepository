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

        public Skills(PlayerCharacter player)
        {
            InitializeComponent();
            this.player = player;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
