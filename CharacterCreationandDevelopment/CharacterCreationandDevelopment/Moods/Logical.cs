using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Moods
{
    class Logical : IMoodBehaviour
    {
        public string GetName()
        {
            return "Logical";
        }

        public void SetMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.wisdom += 3;
        }

        public void RemoveMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.wisdom -= 3;
        }

        public Image GetMoodImage()
        {
            Bitmap bmp = new Bitmap(@"Moods\Images\Logical.png");
            return bmp;
        }
    }
}
