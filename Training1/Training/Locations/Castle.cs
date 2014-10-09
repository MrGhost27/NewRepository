using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Locations
{
	class PlayerCastle : ILocation
	{
		public string Name { get { return "Player Castle"; } }
		public int Population { get { return 1000; } }
		public LocationType Type { get { return LocationType.PlayerCastle; } }
        public Point Location { get; set; }
	}
}
