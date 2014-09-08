using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public interface IMoodBehaviour
    {
        void SetMoodEffectsandModifiers(PlayerCharacter player);
        void RemoveMoodEffectsandModifiers(PlayerCharacter player);
        string GetName();
        Image GetMoodImage();
    }
}
