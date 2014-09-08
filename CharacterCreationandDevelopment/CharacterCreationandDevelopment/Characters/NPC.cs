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
            portrait = HelperClass.MaleImages()[HelperClass.GenerateRandomNumber(0, HelperClass.MaleImages().Count())];
            name = HelperClass.RandomMaleName();
            maxHP = HelperClass.GenerateRandomNumber(0, 100);
            currentHP = maxHP;
        }

        public NPC(string name)
        {
            portrait = HelperClass.MaleImages()[HelperClass.GenerateRandomNumber(0, HelperClass.MaleImages().Count())];
            this.name = name;
            maxHP = HelperClass.GenerateRandomNumber(0, 100);
            currentHP = maxHP;
        }
    }
}
