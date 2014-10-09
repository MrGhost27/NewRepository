using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Units.Abilities
{
	internal static class AbilityFactory
	{
		internal static List<IAbility> Abilities(UnitType type)
		{
			List<IAbility> abilities = new List<IAbility>();
			abilities.Add(new Walk());
			switch (type)
			{
				case UnitType.Archer:
					abilities.Add(new FlameArrows());
					break;
				case UnitType.Spy:
					break;
				case UnitType.Swordsman:
					break;
                case UnitType.Diplomat:
                    abilities.Add(new Diplomacy());
                    break;
				default:
					break;
			}
			return abilities;
		}
	}
}
