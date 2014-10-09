using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Units.Abilities
{
	interface IAbility
	{
		AbilityType Type { get; }
		AbilityTarget TargetType { get; }
		string AbilityName { get; }
		void Do(IUnit unit, World world);
	}
}
