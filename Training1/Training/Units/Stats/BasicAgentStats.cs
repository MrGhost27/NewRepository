using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Units
{
	class BasicAgentStats : IStats
	{
		public int MovementSpeed { get { return 10; } }
		public int CurrentHealth { get { return 50; } }
		public int MaxHealth { get { return 50; } }
		public string Type { get { return "Spy"; } }
	}
}
