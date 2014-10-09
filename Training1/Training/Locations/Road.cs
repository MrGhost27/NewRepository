using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Locations
{
	class Road : ILocation
	{
		public string Name { get { return "Road"; } }
		public int Population { get { return 0; } }
		public LocationType Type { get { return LocationType.Road; } }
        public Point Location { get; set; }
	}
}
