using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Moods
{
    class Bored : IMoodBehaviour
    {
        public string GetName()
        {
            return "Composed";
        }

        public void SetMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.diplomacy += 3;
        }

        public void RemoveMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.diplomacy -= 3;
        }

        public Image GetMoodImage()
        {
            Bitmap bmp = new Bitmap(@"Moods\Images\Bored.png");
            return bmp;
        }
    }
}
