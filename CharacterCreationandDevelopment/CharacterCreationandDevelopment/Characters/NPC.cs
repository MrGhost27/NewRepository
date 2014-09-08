using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class NPC : ICharacter
    {
        public Image portrait { get; set; }
        public string name { get; set; }
        public int currentHP { get; set; }
        public int maxHP { get; set; }

        public NPC()
        {
            portrait = HelperClass.Images()[HelperClass.GenerateRandomNumber(0, HelperClass.Images().Count())];
            name = HelperClass.RandomName();
            maxHP = HelperClass.GenerateRandomNumber(0, 100);
            currentHP = maxHP;
        }

        public NPC(string name)
        {
            portrait = HelperClass.Images()[HelperClass.GenerateRandomNumber(0, HelperClass.Images().Count())];
            this.name = name;
            maxHP = HelperClass.GenerateRandomNumber(0, 100);
            currentHP = maxHP;
        }
    }
}
