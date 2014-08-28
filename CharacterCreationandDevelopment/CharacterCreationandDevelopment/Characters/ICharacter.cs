using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    interface ICharacter
    {
        Image portrait { get; set; }
        string name { get; set; }
        int currentHP { get; set; }
        int maxHP { get; set; }
    }
}
