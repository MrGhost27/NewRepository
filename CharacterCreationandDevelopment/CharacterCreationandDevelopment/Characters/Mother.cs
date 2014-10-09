using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class Mother : Relationship
    {
        public Mother()
        {
            this.portraitNumber = 3;
            this.name = HelperClass.RandomName(0);
            opinionofPlayer = 100;
            playerOpinion = 100;
            type = "Mother";
        }
    }
}
