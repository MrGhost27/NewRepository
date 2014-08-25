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
        Image Portrait { get; set; }
        string Name { get; set; }
        int CurrentHP { get; set; }
        int MaxHP { get; set; }
    }
}
