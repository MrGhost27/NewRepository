﻿using System;
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
		public int swimming { get; set; }
		public int athletics { get; set; }
		public int diplomacy { get; set; }
		public int survival { get; set; }
		public int crafting { get; set; }

        #endregion

        public IMoodBehaviour CurrentMood;


        public PlayerCharacter(string Name, int Str, int Dex, int Const, int Int, int Wis, int Char, int imageNumber, 
			int weapons, int swimming, int athletics, int diplomacy, int survival, int crafting)
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
			this.swimming = swimming;
			this.athletics = athletics;
			this.diplomacy = diplomacy;
			this.survival = survival;
			this.crafting = crafting;

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
