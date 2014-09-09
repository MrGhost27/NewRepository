using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public interface ICharacter
    {
		string name { get; set; }
		int opinionofPlayer { get; set; }
		int playerOpinion { get; set; }
		Image portrait { get; set; }
    }
}
