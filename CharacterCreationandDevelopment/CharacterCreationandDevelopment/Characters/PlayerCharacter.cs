using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public static class PlayerCharacter
    {
        #region InterfaceFields
        public static  string name { get; set; }
        public static Image portrait { get; set; }
        public static int currentHP { get; set; }
        public static int maxHP { get; set; }
        #endregion  

        #region Attributes
        public static int strength { get; set; }
        public static int dexterity { get; set; }
        public static int constitution { get; set; }
        public static int intelligence { get; set; }
        public static int wisdom { get; set; }
        public static int charisma { get; set; }
        #endregion

        public static IMoodBehaviour CurrentMood;

        public static void SetMood (IMoodBehaviour newMood)
        {
            CurrentMood.RemoveMoodEffectsandModifiers();
            CurrentMood = newMood;
            CurrentMood.SetMoodEffectsandModifiers();
        }
 

    }
}
