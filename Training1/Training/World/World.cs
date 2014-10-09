using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Locations;
using Training.Units;
using Training.Units.Abilities;

namespace Training
{
	class World
	{
		private DateTime currentDate;
		private List<ILocation> locationList;
		private List<IUnit> unitList;

		internal World()
		{
			currentDate = new DateTime(1050, 1, 1);
			locationList = new List<ILocation>();
			unitList = new List<IUnit>();
			SetLocationList();
		}

		internal string CityReport(string cityName)
		{
			ILocation city = SelectCity(cityName);
			string report = "";
			if (cityName.Length > 0)
			{
				report += string.Format("Name: {0}", city.Name) + Environment.NewLine;
				report += string.Format("Population: {0}", city.Population) + Environment.NewLine;
			}
			return report;
		}

		internal void NextDay()
		{
			currentDate = currentDate.AddDays(1);
			foreach (City location in locationList.OfType<City>())
			{
                if (currentDate.Day.Equals(1))
                {
                    location.UpdatePopulation();
                }
			}
		}

		internal void Go()
		{
			foreach (IUnit unit in unitList)
			{
				if (unit.CurrentAbility != null)
				{
					unit.CurrentAbility.Do(unit, this);
				}
			}
		}

		internal void AddUnit(UnitType type, string selectedCity)
		{
                var newUnit = UnitFactory.SpawnUnit(type, GetLocation(selectedCity).Location);
                unitList.Add(newUnit);
		}

		internal IUnit SelectUnit(string cityName, int Index)
		{
			return CityUnitList(cityName)[Index];
		}

		internal ILocation SelectCity(string cityName)
		{
			foreach (ILocation location in locationList)
			{
				if ((location.Name).Equals(cityName))
				{
					return location;
				}
			}
			return null;
		}

		internal List<IUnit> WorldUnitList()
		{
			return unitList;
		}

		internal List<IUnit> CityUnitList(string cityName)
		{
			List<IUnit> CityUnitList = new List<IUnit>();
			Point CityLocation = GetLocation(cityName).Location;
			foreach (IUnit unit in unitList)
			{
				if (unit.Location == CityLocation)
				{
					CityUnitList.Add(unit);
				}
			}
			return CityUnitList;
		}

		internal string Date()
		{
            //string day = currentDate.ToString("dd");
            //string month = currentDate.ToString("MMM");
            //string year = currentDate.Year.ToString();
			return string.Format(currentDate.ToString("MMM dd, yyyy"));
		}

		internal List<ILocation> Locations()
		{
			return locationList;
		}

		internal ILocation GetLocation(string locationName)
		{
			foreach (ILocation location in locationList)
			{
				if (locationName.Equals(location.Name))
				{
					return location;
				}
			}
			return null;
		}

		private void SetLocationList()
		{
			locationList.Add(LocationFactory.GetLocation(LocationType.PlayerCastle));
			for (int i = 0; i < 4; i++)
			{
				locationList.Add(LocationFactory.GetLocation(LocationType.City));
			}
		}
	}
}
