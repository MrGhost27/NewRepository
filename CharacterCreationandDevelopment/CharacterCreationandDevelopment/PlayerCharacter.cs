using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class PlayerCharacter
    {
        #region Attributes;
        string _Name { get; set; }
        int _Strength { get; set; }
        int _Dexterity { get; set; }
        int _Constitution { get; set; }
        int _Intelligence { get; set; }
        int _Wisom { get; set; }
        int _Charisma { get; set; }
        #endregion


        public PlayerCharacter(string Name, int Str, int Dex, int Const, int Int, int Wis, int Char)
        {
            this._Name = Name;
            this._Strength = Str;
            this._Dexterity = Dex;
            this._Constitution = Const;
            this._Intelligence = Int;
            this._Wisom = Wis;
            this._Charisma = Char;
        }
 

    }
}
