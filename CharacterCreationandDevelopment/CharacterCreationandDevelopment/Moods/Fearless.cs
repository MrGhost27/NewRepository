using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Moods
{
    class Fearless: IMoodBehaviour
    {
        public string GetName()
        {
            return "Fearless";
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
            Bitmap bmp = new Bitmap(@"Moods\Images\Fearless.jpg");
            return bmp;
        }
    }
}
