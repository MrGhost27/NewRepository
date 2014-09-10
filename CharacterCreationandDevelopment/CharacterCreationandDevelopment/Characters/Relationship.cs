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
		public int portraitNumber { get; set; }
        public string name { get; set; }
		public string type { get; set; }
		public int opinionofPlayer { get; set; }
		public int playerOpinion { get; set; }

        public Relationship(string type, string name, int portraitNumber)
        {
			this.portraitNumber = portraitNumber;
			this.portrait = HelperClass.Images(3)[portraitNumber];
			this.name = name;
			this.type = type;
			opinionofPlayer = 100;
			playerOpinion = 100;
        }
    }
}
