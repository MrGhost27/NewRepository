using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class Relationship : ICharacter
    {
        public Image portrait { get; set; }
        public string name { get; set; }
		public int opinionofPlayer { get; set; }
		public int playerOpinion { get; set; }

        public Relationship(string name, Image portrait)
        {
			this.portrait = portrait;
			this.name = name;
			opinionofPlayer = 100;
			playerOpinion = 100;
        }
    }
}
