using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Locations
{
	class LocationFactory
	{
		internal static ILocation GetLocation(LocationType type)
		{
			ILocation location = null;
			switch (type)
			{
				case LocationType.City:
					location = new City();
					break;
				case LocationType.PlayerCastle:
					location = new PlayerCastle();
					break;
				case LocationType.Road:
					location = new Road();
					break;
				default:
					break;
			}
			return location;
		}
	}
}
