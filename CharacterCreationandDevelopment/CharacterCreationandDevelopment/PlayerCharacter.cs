using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class PlayerCharacter : ICharacter
    {
        #region InterfaceFields
        public string Name { get; set; }
        public Image Portrait { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        #endregion  

        #region Attributes
        public int _Strength { get; set; }
        public int _Dexterity { get; set; }
        public int _Constitution { get; set; }
        public int _Intelligence { get; set; }
        public int _Wisom { get; set; }
        public int _Charisma { get; set; }
        #endregion

        public IMoodBehaviour CurrentMood;


        public PlayerCharacter(string Name, int Str, int Dex, int Const, int Int, int Wis, int Char, Image Portrait)
        {
            this.Name = Name;
            this._Strength = Str;
            this._Dexterity = Dex;
            this._Constitution = Const;
            this._Intelligence = Int;
            this._Wisom = Wis;
            this._Charisma = Char;
            this.Portrait = Portrait;
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
