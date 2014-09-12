using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class Market : Location
    {
        public Market()
        {
            locationName = "The Market";
        }

        public override List<string> GetActions(PlayerCharacter player)
        {
            actionlist.Add("Barter for Food");
            if (player.ageYears > 10)
            {
                AddActionByAttribute(player.pickpocketing, 20, "Steal Food");
            }
            return actionlist;
        }
    }//			ChangeLocation("The Market", "Barter for Food", "Steal Food");
}
