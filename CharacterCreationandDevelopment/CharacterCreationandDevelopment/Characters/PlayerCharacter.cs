using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class PlayerCharacter
    {
        #region InterfaceFields
        public string name { get; set; }
        public int portraitNumber { get; set; }
        public int currentHP { get; set; }
        public int maxHP { get; set; }
        #endregion  

        #region Attributes
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }
        #endregion

        #region LearntSkills
        public int weapons { get; set; }
		public int unarmed { get; set; }
		public int swimming { get; set; }
		public int athletics { get; set; }
		public int diplomacy { get; set; }
		public int survival { get; set; }
		public int crafting { get; set; }
		public int faith { get; set; }
		public int lockpicking { get; set; }
		public int pickpocketing { get; set; }
		public int animalEmpathy { get; set; }
		public int medicine { get; set; }
        public int science { get; set; }

        #endregion

        public IMoodBehaviour CurrentMood;


        public PlayerCharacter(string Name, int Str, int Dex, int Const, int Int, int Wis, int Char, int imageNumber, 
			int weapons, int unarmed, int swimming, int athletics, int diplomacy, int survival, int crafting, int faith,
			int lockpicking, int pickpocketing, int animalEmpathy, int medicine, int science)
        {
            this.name = Name;
            this.strength = Str;
            this.dexterity = Dex;
            this.constitution = Const;
            this.intelligence = Int;
            this.wisdom = Wis;
            this.charisma = Char;
            this.portraitNumber = imageNumber;
            this.weapons = weapons;
			this.unarmed = unarmed;
			this.swimming = swimming;
			this.athletics = athletics;
			this.diplomacy = diplomacy;
			this.survival = survival;
			this.crafting = crafting;
			this.faith = faith;
			this.lockpicking = lockpicking;
			this.pickpocketing = pickpocketing;
			this.animalEmpathy = animalEmpathy;
			this.medicine = medicine;
            this.science = science;

            CurrentMood = new Happy();
        }

        public void SetMood (IMoodBehaviour newMood)
        {
            this.CurrentMood.RemoveMoodEffectsandModifiers(this);
            this.CurrentMood = newMood;
            this.CurrentMood.SetMoodEffectsandModifiers(this);
        }
 

    }
}
