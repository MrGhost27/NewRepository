using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class ForestPath : Location
    {
        public ForestPath()
        {
            locationName = "The Forest Path";
        }

        public override List<string> GetActions(PlayerCharacter player)
        {
            actionlist.Add("Climb Trees");
            actionlist.Add("Run around");
            actionlist.Add("Try talking to the animals");
            
            if (player.ageYears > 11)
            {
                actionlist.Add("Go Hunting");
                actionlist.Add("Go Camping");
                actionlist.Add("Leave Village");
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
