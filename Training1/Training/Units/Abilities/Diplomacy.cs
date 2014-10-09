using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Units.Abilities
{
    class Diplomacy : IAbility
    {
        public AbilityType Type { get { return AbilityType.Area; } }
        public string AbilityName { get { return "Diplomacy"; } }
		public AbilityTarget TargetType { get { return AbilityTarget.City ; } }

		public void Do(IUnit unit, World world)
        {
			//return "Doing Diplomacy";
        }
    }
}
