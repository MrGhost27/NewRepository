using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Units
{
	internal static class UnitFactory
	{
		internal static IUnit SpawnUnit(UnitType type, Point location)
		{
			IUnit unit = null;
			switch (type)
			{
				case UnitType.Spy:
					unit = AddUnit(location, new BasicSpy());
					break;
				case UnitType.Swordsman:
					unit = AddUnit(location, new BasicSwordsman());
					break;
				case UnitType.Archer:
					unit = AddUnit(location, new BasicArcher());
					break;
                case UnitType.Diplomat:
					unit = AddUnit(location, new BasicDiplomat());
                    break;
				default:
					break;
			}
			return unit;
		}

		private static IUnit AddUnit(Point location, IUnit unit)
		{
			unit.SetLocation(location);
			return unit;
		}
	}
}
