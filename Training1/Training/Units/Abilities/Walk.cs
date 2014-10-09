using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Locations;

namespace Training.Units.Abilities
{
	class Walk : IAbility
	{
		public AbilityType Type { get { return AbilityType.Move; } }
		public string AbilityName { get { return "Walk"; } }
		public AbilityTarget TargetType { get { return AbilityTarget.City; } }


		public void Do(IUnit unit, World world)
		{
			//City Location, Not top Left Label location.
			Point target = world.GetLocation(unit.Target).Location;
			Point unitLocation = unit.Location;

			int MoveRate = unit.BaseStats.MovementSpeed;
			if (Math.Abs(target.X - unitLocation.X) <= MoveRate &&
				Math.Abs(target.Y - unitLocation.Y) <= MoveRate)
			{
				unit.SetLocation(target);
				unit.CurrentAbility = null;
			}
			else
			{
				if (target.X > unitLocation.X)
					unitLocation.X += MoveRate;
				else if (target.X < unitLocation.X)
					unitLocation.X -= MoveRate;

				if (target.Y > unitLocation.Y)
					unitLocation.Y += MoveRate;
				else if (target.Y < unitLocation.Y)
					unitLocation.Y -= MoveRate;

				unit.SetLocation(unitLocation);
			}
		}
	}
}

