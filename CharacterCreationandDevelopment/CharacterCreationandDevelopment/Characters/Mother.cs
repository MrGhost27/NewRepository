using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    class Mother : ICharacter
    {
        public Image portrait { get; set; }
        public string name { get; set; }
		public int opinionofPlayer { get; set; }
		public int playerOpinion { get; set; }

        public Mother()
        {
            portrait = HelperClass.Images(3)[1];
			name = "Mum";
			opinionofPlayer = 100;
			playerOpinion = 100;
        }
    }
}
