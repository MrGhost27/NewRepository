using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class Barracks: Location
    {
        public Barracks()
        {
            locationName = "The Barracks";
        }

        public override List<string> GetActions(PlayerCharacter player)
        {
            actionlist.Add("Train With Fists");
            actionlist.Add("Go Running");
            
            if (player.ageYears > 11)
            {
                actionlist.Add("Train With Medics");
                actionlist.Add("Train With Weapons");
            }

            if (player.ageYears > 12)
            {
                actionlist.Add("Take Survival Training");
            }
            return actionlist;

            //ChangeLocation("The Barracks", "Go Running", "Train With Medics", "Train With Fists", "Train With Weapons","Take Survival Training");
        }  
    }
}
