using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Units.Stats
{
	class BasicSoldierStats : IStats
	{
		public int MovementSpeed { get { return 5; } }
		public int CurrentHealth { get { return 100; } }
		public int MaxHealth { get { return 100; } }
	}
}
