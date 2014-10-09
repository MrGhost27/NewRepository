using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Locations
{
	interface ILocation
	{
		string Name { get; }
		int Population { get; }
		LocationType Type { get; }
        Point Location { get; set; }
	}
}
