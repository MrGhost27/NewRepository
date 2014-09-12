using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class Farm : Location
    {
        public Farm()
        {
            locationName = "Your Home";
        }

        public override List<string> GetActions(PlayerCharacter player)
        {
            actionlist.Add("Relax at Home");
            actionlist.Add("Help Mum with Housework");
            actionlist.Add("Steal from the house");
            AddActionOnMood(player, "Happy", "Show off your Happiness");
            AddActionOnMood(player, "Depressed", "Have a Cry");
            
            if (player.ageYears > 10)
            {
                actionlist.Add("Work on the Farm");
                //AddAction(player.animalEmpathy, 50, "Talk to the Animals");
            }
            return actionlist;
        }
    }
}
