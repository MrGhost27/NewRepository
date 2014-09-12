using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public abstract class Relationship : ICharacter
    {
		public int portraitNumber { get; set; }
        public string name { get; set; }
		public string type { get; set; }
		public int opinionofPlayer { get; set; }
		public int playerOpinion { get; set; }

        public virtual Image GetPortrait()
        {
            return HelperClass.Images(3)[portraitNumber];
        }
    }

}
