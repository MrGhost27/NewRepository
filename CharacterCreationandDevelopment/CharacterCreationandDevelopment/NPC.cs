using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    class NPC : ICharacter
    {
        public Image Portrait { get; set; }
        public string Name { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }

        public NPC()
        {
            Portrait = HelperClass.Images()[HelperClass.GenerateRandomNumber(0, HelperClass.Images().Count())];
            Name = HelperClass.RandomName();
            MaxHP = HelperClass.GenerateRandomNumber(0, 100);
            CurrentHP = MaxHP;
        }
    }
}
