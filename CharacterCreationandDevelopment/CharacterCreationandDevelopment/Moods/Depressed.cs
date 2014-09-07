using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Moods
{
    class Depressed : IMoodBehaviour
    {
        public string GetName()
        {
            return "Depressed";
        }

        public void SetMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.survival += 3;
        }

        public void RemoveMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.survival -= 3;
        }

        public Image GetMoodImage()
        {
            Bitmap bmp = new Bitmap(@"Moods\Images\Depressed.jpg");
            return bmp;
        }
    }
}
