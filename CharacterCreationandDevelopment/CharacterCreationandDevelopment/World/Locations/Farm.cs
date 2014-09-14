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
            actionlist.Add("Help Mum around the House");
            AddActionOnMood(player, "Happy", "Show off your Happiness");
            AddActionOnMood(player, "Depressed", "Have a Cry");
            
            if (player.ageYears > 10)
            {
                actionlist.Add("Work on the Farm");
                actionlist.Add("Steal from the house");
                //AddAction(player.animalEmpathy, 50, "Talk to the Animals");
            }
            return actionlist;
        }
    }
}
