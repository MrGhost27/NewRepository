using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class School : Location
    {
        public School()
        {
            locationName = "The School";
        }

        public override List<string> GetActions(PlayerCharacter player)
        {
            if (player.ageYears > 12)
            {
                actionlist.Add("Take Science Class");
                actionlist.Add("Take Medical Class");
                AddActionByAttribute(player.lockpicking, 10, "Break into the School");
            }
            return actionlist;
        }//			ChangeLocation("The School", "Take Science Class", "Take Medical Class", "Break into the School");
    }
}
