using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Units.Abilities;
using Training.Units.Stats;

namespace Training.Units
{
	class BasicSpy : BaseUnit, IUnit
	{
		public IStats BaseStats { get { return StatFactory.GetStats(StatType.BasicAgent); } }
		public List<IAbility> Abilities { get { return AbilityFactory.Abilities(UnitType.Spy); } }
		public string Type { get { return "Spy"; } }
		public Image Image { get { return Properties.Resources.spy; } }
	}
}
