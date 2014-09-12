using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class Bandit : Relationship
    {
        public Bandit(int gender)
        {
            this.portraitNumber = 0;
            this.name = HelperClass.RandomName(1);
            opinionofPlayer = -100;
            playerOpinion = 100;
        }

        public override Image GetPortrait()
        {
            return HelperClass.Images(2)[portraitNumber];
        }
    }
}
