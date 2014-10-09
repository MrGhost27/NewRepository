using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class Lake : Location
    {
        public Lake()
        {
            locationName = "The Lake";
        }

        public override List<string> GetActions(PlayerCharacter player)
        {
            if (player.ageYears > 10)
            {
				actionlist.Add("Go Swimming");
                actionlist.Add("Go Camping");
            }
            return actionlist;
        }
    }//			ChangeLocation("The Lake", "Go Swimming", "Go Camping");
}
