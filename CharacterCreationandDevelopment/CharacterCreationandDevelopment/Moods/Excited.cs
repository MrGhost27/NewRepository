using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Moods
{
    class Excited: IMoodBehaviour
    {
        public string GetName()
        {
            return "Excited";
        }

        public void SetMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.unarmed += 3;
        }

        public void RemoveMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.unarmed -= 3;
        }

        public Image GetMoodImage()
        {
            Bitmap bmp = new Bitmap(@"Moods\Images\Excited.png");
            return bmp;
        }
    }
}
