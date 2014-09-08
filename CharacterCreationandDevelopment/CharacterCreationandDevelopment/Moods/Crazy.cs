using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Moods
{
    class Crazy : IMoodBehaviour
    {
        public string GetName()
        {
            return "Crazy";
        }

        public void SetMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.faith += 3;
        }

        public void RemoveMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.faith -= 3;
        }

        public Image GetMoodImage()
        {
            Bitmap bmp = new Bitmap(@"Moods\Images\Insane.jpg");
            return bmp;
        }
    }
}
