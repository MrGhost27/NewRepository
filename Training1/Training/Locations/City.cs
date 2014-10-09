using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Helper;

namespace Training.Locations
{
	class City : ILocation
	{
		public string Name { get { return _locationName; } }
		public int Population { get { return _population; } }
		public LocationType Type { get { return LocationType.City; } }
        public Point Location { get; set; }

		private int _population = 100;
		private string _locationName = LocationName();

		public int UpdatePopulation()
		{
			int value = Helper.Helper.GenerateRandomNumber(-10, 10);
			_population += value;
			return _population;
		}

		internal static string LocationName()
		{
			string filepath = @"Locations\ListOfCities.txt";
			string[] locationNames = System.IO.File.ReadAllLines(filepath);

			return locationNames[Helper.Helper.GenerateRandomNumber(1, locationNames.Count())];
		}
	}
}
