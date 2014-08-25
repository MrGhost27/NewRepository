using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    class Happy : IMoodBehaviour
    {
        public void SetMoodEffectsandModifiers()
        {
            PlayerCharacter.charisma += 3;
        }

        public void RemoveMoodEffectsandModifiers()
        {
            PlayerCharacter.charisma -= 3;
        }
    }
}
