﻿using CharacterCreationandDevelopment.Lessons;
using CharacterCreationandDevelopment.Moods;
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
        #region CharDetails
        public string name { get; set; }
		public int gender { get; set; }
		public string location { get; set; }
        public int portraitNumber { get; set; }
		public int ageYears { get; set; }
		public int ageMonths { get; set; }
        //public int currentHP { get; set; }
        //public int maxHP { get; set; }
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
        public int running { get; set; }
        public int climbing { get; set; }
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

        #region Mood

        public int happyDepressed { get; private set; }
        public int angryAfraid { get; private set; }
        public int excitedBored { get; private set; }
        public int logicalCrazy { get; private set; }
        public int[] moodValues {get; set;}


        #endregion


        public IMoodBehaviour CurrentMood;
        public ILesson lesson;

        public PlayerCharacter(string Name, int gender, string location, int Str, int Dex, int Const, int Int, int Wis, int Char, int imageNumber, 
			int weapons, int unarmed, int swimming, int running, int climbing, int diplomacy, int survival, int crafting, int faith,
			int lockpicking, int pickpocketing, int animalEmpathy, int medicine, int science, int ageYears, int ageMonths,
			int happyDepressed, int angryAfraid, int excitedBored, int logicalCrazy)
        {
            this.name = Name;
			this.gender = gender;
			this.location = location;
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
            this.running = running;
            this.climbing = climbing;
			this.diplomacy = diplomacy;
			this.survival = survival;
			this.crafting = crafting;
			this.faith = faith;
			this.lockpicking = lockpicking;
			this.pickpocketing = pickpocketing;
			this.animalEmpathy = animalEmpathy;
			this.medicine = medicine;
            this.science = science;
			this.ageYears = ageYears;
			this.ageMonths = ageMonths;

            this.happyDepressed = happyDepressed;
			this.angryAfraid = angryAfraid;
			this.excitedBored = excitedBored;
			this.logicalCrazy = logicalCrazy;

            GetMood();
        }

		public void SetHappyDepressed(int value)
        {
            happyDepressed += value;
			happyDepressed = HelperClass.SetMoodBoundaries(happyDepressed);
        }

        public void SetAngryAfraid(int value)
        {
			angryAfraid += value;
			angryAfraid = HelperClass.SetMoodBoundaries(angryAfraid);
        }

        public void SetExcitedBored(int value)
        {
			excitedBored += value;
			excitedBored = HelperClass.SetMoodBoundaries(excitedBored);
        }

        public void SetLogicalCrazy(int value)
        {
			logicalCrazy += value;
			logicalCrazy = HelperClass.SetMoodBoundaries(logicalCrazy);
        }


        public void GetMood()
        {
			moodValues = new int[] { happyDepressed, angryAfraid, excitedBored, logicalCrazy };
            int max = moodValues.Max();
            int min = moodValues.Min();

            if (Math.Abs(min) > Math.Abs(max))
            {
                int index = Array.IndexOf(moodValues, moodValues.Min());
                switch (index)
                {
                    case 0:
                        SetMood(new Depressed());
                        break;
                    case 1:
                        SetMood(new Afraid());
                        break;
                    case 2:
                        SetMood(new Bored());
                        break;
                    case 3:
                        SetMood(new Crazy());
                        break;
                }
            }
            else
            {
                int index = Array.IndexOf(moodValues, moodValues.Max());
                switch (index)
                {
                    case 0:
                        SetMood(new Happy());
                        break;
                    case 1:
                        SetMood(new Angry());
                        break;
                    case 2:
                        SetMood(new Excited());
                        break;
                    case 3:
                        SetMood(new Logical());
                        break;
                }
            }
        }

        private void SetMood (IMoodBehaviour newMood)
        {
            this.CurrentMood = newMood;
            this.CurrentMood.RemoveMoodEffectsandModifiers(this);
            this.CurrentMood.SetMoodEffectsandModifiers(this);
        }

        public void SetLesson(ILesson todaysLesson)
        {
            this.lesson = todaysLesson;
        }
    }
}
