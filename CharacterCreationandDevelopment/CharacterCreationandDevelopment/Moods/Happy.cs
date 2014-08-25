using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    class Happy : IMoodBehaviour
    {
        public void SetMoodEffectsandModifiers(PlayerCharacter player)
        {
            player._Charisma += 3;
        }

        public void RemoveMoodEffectsandModifiers(PlayerCharacter player)
        {
            player._Charisma -= 3;
        }
    }
}
