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
	class BaseUnit
	{
		private Point location;
		public Point Location { get { return location; } }
		public StateType CurrentState { get; private set; }
		public IAbility CurrentAbility { get; set; }
		public string Target{ get; set; }

		public void SetLocation(Point point)
		{
			location = point;
		}
	}
}
