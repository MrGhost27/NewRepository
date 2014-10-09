using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Locations;
using Training.Units.Abilities;


namespace Training.Units
{
	interface IUnit
	{
		IStats BaseStats { get; }
		List<IAbility> Abilities { get; }
		string Type { get; }
		Image Image { get; }
		Point Location { get; }
		void SetLocation(Point point);
		string Target { get; set; }
		IAbility CurrentAbility { get; set; }
	}
}
