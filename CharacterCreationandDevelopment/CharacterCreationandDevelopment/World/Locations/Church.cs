using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class Church : Location
    {
        public Church()
        {
            locationName = "The Church";
        }

        public override List<string> GetActions(PlayerCharacter player)
        {
            actionlist.Add("Go to Prayer with Family");
            if (player.ageYears > 10)
            {
                AddActionByAttribute(player.faith, 10, "Go to confession");
                AddActionByAttribute(player.lockpicking, 10, "Break into Church");
            }
            return actionlist;
        }
    }
}
