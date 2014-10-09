using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Units.Abilities
{
	class FlameArrows : IAbility
	{
		public AbilityType Type { get { return AbilityType.Ranged; } }
		public string AbilityName { get { return "Flame Arrows"; } }
		public AbilityTarget TargetType { get { return AbilityTarget.Unit; } }

		public void Do(IUnit unit, World world)
		{
			//return "Firing Flame Arrows";
		}
	}
}
