using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Moods
{
    class Angry : IMoodBehaviour
    {
        public string GetName()
        {
            return "Angry";
        }

        public void SetMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.weapons += 3;
        }

        public void RemoveMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.weapons -= 3;
        }

        public Image GetMoodImage()
        {
            Bitmap bmp = new Bitmap(@"Moods\Images\Angry.png");
            return bmp;
        }
    }
}
