﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class Blacksmith : Location
    {
        public Blacksmith()
        {
            locationName = "The Blacksmith";
        }

        public override List<string> GetActions(PlayerCharacter player)
        {
            if (player.ageYears > 10)
            {
				actionlist.Add("Barter for Items");
                AddActionByAttribute(player.diplomacy, 20, "Work at the Smith");
                AddActionByAttribute(player.pickpocketing, 50, "Steal Items");
                AddActionByAttribute(player.crafting, 50, "Create Items");
            }
            return actionlist;
        }
    }
    //ChangeLocation("The Blacksmith", "Barter for Items", "Steal Items", "Create Items", "Break In");
}
