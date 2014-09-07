using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Moods
{
    class Scared : IMoodBehaviour
    {
        public string GetName()
        {
            return "Scared";
        }

        public void SetMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.animalEmpathy += 3;
        }

        public void RemoveMoodEffectsandModifiers(PlayerCharacter player)
        {
            player.animalEmpathy -= 3;
        }

        public Image GetMoodImage()
        {
            Bitmap bmp = new Bitmap(@"Moods\Images\Scared.jpg");
            return bmp;
        }
    }
}
