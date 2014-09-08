using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    class Happy : IMoodBehaviour
    {
        public string GetName()
        {
            return "Happy";
        }

        public void SetMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.charisma += 3;
        }

        public void RemoveMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.charisma -= 3;
        }

        public Image GetMoodImage()
        {
            Bitmap bmp = new Bitmap(@"Moods\Images\Happy.png");
            return bmp;
        }
    }
}
