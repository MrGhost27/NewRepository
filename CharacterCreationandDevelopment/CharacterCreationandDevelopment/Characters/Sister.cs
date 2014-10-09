using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class Sister : Relationship
    {
        public Sister()
        {
            this.portraitNumber = HelperClass.GenerateRandomNumber(0, 3);
            this.name = HelperClass.RandomName(0);
            opinionofPlayer = 100;
            playerOpinion = 100;
            type = "Sister";
        }
    }
}
