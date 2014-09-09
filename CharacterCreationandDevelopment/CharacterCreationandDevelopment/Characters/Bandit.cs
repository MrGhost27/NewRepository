using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class Bandit : ICharacter
    {
		public Image portrait { get; set; }
        public string name { get; set; }
		public int opinionofPlayer { get; set; }
		public int playerOpinion { get; set; }

        public Bandit(int gender)
        {
            portrait = HelperClass.Images(2)[0];
			name = HelperClass.RandomName(gender);
			opinionofPlayer = -100;
			playerOpinion = -100;
        }
    }
}
