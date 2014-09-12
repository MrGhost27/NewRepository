using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public abstract class Location
    {
        protected List<string> actionlist = new List<string>();
        public string locationName { get; set; }
        public abstract List<string> GetActions(PlayerCharacter player);

        protected void AddActionByAttribute(int playerAttribute, int check, string action)
        {
            if (playerAttribute > check)
            {
                actionlist.Add(action);
            }
        }

        protected void AddActionOnMood(PlayerCharacter player, string check, string action)
        {
            if (player.CurrentMood.GetName() == check)
            {
                actionlist.Add(action);
            }
        }
    }
}
